using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.ComponentModel.Design.Serialization;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Newtonsoft.Json;
using Nds.Borrower.GraphQl.Util;
using Nds.Borrower.GraphQl.Models;
using Nds.EPWorkflow.Provider.Models;
using Nds.Borrower.Common;
using Nds.Borrower.Common.Entities;
using Nds.Borrower.Common.Interfaces;
using Newtonsoft.Json.Linq;

using System.Xml;
using System.Xml.Serialization;


namespace Nds.Borrower.GraphQl.Schema
{
    class BeaconResolvers
    {
        public static Task<Nds.Borrower.GraphQl.Models.Borrower> GetBorrowerBySsnAsync(string ssn)
        {
            //Try to get from cache
            var cachedBorrower = CacheManager.Get<Nds.Borrower.GraphQl.Models.Borrower>(ssn);

            if (cachedBorrower != null)
            {
                return Task.FromResult(cachedBorrower);
            }

            var newBorrower = Task.FromResult(GetBorrowerSummary(ssn, "http://dev.intsvc.nelnet.net:4106/api/workspace/v1/"));
            //Clear the address since for the prototype we are going to call the system i REST GetBorrowerByAddress
            //TODO - change the LoanProvider to only return the minimum borrower fields, the rest will get
            //  returned as needed when included in a GraphQL query
            newBorrower.Result.Addresses = null;

            // Add this borrower to the cache
            CacheManager.Set(ssn, newBorrower.Result);
            return newBorrower;
        }

        public static List<Activity> GetActivityBySsn(string ssn)
        {
            var container = CreateConfiguredUnityContainer();
            IEnumerable<IWorkflowProvider>  providers = container.ResolveAll<IWorkflowProvider>();

            var requests = new ConcurrentDictionary<string, List<Activity>>();

            Parallel.ForEach(providers, provider =>
            {
                try
                {
                    requests.TryAdd(provider.GetProviderName(), provider.GetBorrowerActivitiesBySsn(1, ssn, "0C904AB2-1A46-4036-80D7-A3B50E12D2EA", "mockprocessor"));
                }
                catch (Exception )
                {

                }
            });

            var allRequests = ConsolidateRequests(requests);
            return allRequests;

        }

        public static List<Address> GetAddressesBySsn(string ssn)
        {
            Models.Borrower borrower;
            
            //Try to get from cache
            var cachedBorrower = CacheManager.Get<Nds.Borrower.GraphQl.Models.Borrower>(ssn);

            if (cachedBorrower == null)
            {
                cachedBorrower = GetBorrowerBySsnAsync(ssn).Result;
            }

            var addresses = cachedBorrower.Addresses;

            if (addresses != null && addresses.Count > 0)
            {
                return addresses;
            }
            else
            {
                var newAddresses = GetBorrowerAddresses(ssn, "http://itidev.us.nelnet.biz:10024/");
                cachedBorrower.Addresses = newAddresses;
                CacheManager.Set(ssn, cachedBorrower);
                return newAddresses;
            }
        }

        static Microsoft.Practices.Unity.IUnityContainer CreateConfiguredUnityContainer()
        {
            Microsoft.Practices.Unity.IUnityContainer container = new UnityContainer();

            //container.RegisterType<IWorkflowProvider, Nds.EPWorkflow.Provider.EPWorkflowProvider>();
            container.LoadConfiguration();
            return container;
        }

        static List<Activity> ConsolidateRequests(ConcurrentDictionary<string, List<Activity>> requests)
        {
            List<Activity> allRequests = new List<Activity>();

            foreach (var pair in requests)
            {
                if (pair.Value != null)
                {
                    allRequests.AddRange(pair.Value);
                }

            }

            return allRequests;
        }

        public static Nds.Borrower.GraphQl.Models.Borrower GetBorrowerSummary(string borrowerId, string baseUri)
        {
            string id = borrowerId;
            string domain = "US";
            string user = "workflow";
            string requestId = Guid.NewGuid().ToString();
            string dateVal = DateTime.Now.ToShortDateString();
            string idrAppId = "15"; // 1 was default, 15 is for IDR
            string nelnetClientId = "1"; //Nelnet

            string requestUri = string.Format("borrowersummarybyssn/{0}/{1}/{2}/{3}/{4}/{5}", idrAppId, nelnetClientId, domain, user, id, requestId);
            Console.WriteLine(requestUri);
           
            using (var client = new HttpClient { BaseAddress = new Uri(baseUri) })
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync(requestUri).Result;

                if (response == null || !response.IsSuccessStatusCode)
                {
                    if (response != null)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;
                        if (result != null)
                        {
                            Console.WriteLine("Result:  " + result);
                            throw new Exception("Result:  " + result);
                        }
                        else
                        {
                            Console.WriteLine("result is null");
                        }
                    }
                    else
                    {
                        Console.WriteLine("response is null");
                    }
                }

                string json = response.Content.ReadAsStringAsync().Result;

                if (!string.IsNullOrEmpty(json) && json.ToLower() != "null") //for some reason sometimes the call will return the string "null"
                {
                    return GetBorrowerFromJson(json);
                }
                else
                {
                    throw new HttpRequestException("Borrower was not found.");
                }
            }
        }

        public static List<Address> GetBorrowerAddresses(string borrowerId, string baseUri)
        {
            string requestId = Guid.NewGuid().ToString();
            string dateVal = DateTime.Now.ToShortDateString();

            string requestUri = string.Format("Q20_GetBorrowerAddress/{0}/{1}", borrowerId, "All");
            Console.WriteLine(requestUri);

            using (var client = new HttpClient { BaseAddress = new Uri(baseUri) })
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync(requestUri).Result;

                if (response == null)
                {
                    return new List<Address>();
                }
                else if (!response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;
                    if (result != null)
                    {
                        Console.WriteLine("Result:  " + result);
                        throw new Exception("Result:  " + result);
                    }
                    else
                    {
                        Console.WriteLine("result is null");
                    }
                }

                string json = response.Content.ReadAsStringAsync().Result;

                if (!string.IsNullOrEmpty(json) && json.ToLower() != "null") //for some reason sometimes the call will return the string "null"
                {
                    return GetAddressesFromJson(json);
                }
                else
                {
                    throw new HttpRequestException("Borrower was not found.");
                }
            }
        }

        public static Models.Borrower GetBorrowerFromJson(string borrowerSummary)
        {

            try
            {
                Models.Borrower borrower = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Borrower>(borrowerSummary);
                return borrower;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// Get a list of Address objects from the Json we got from the i series service
        ///   The format will be similiar to this, so we need to only get the Address array
        /// {
        /// "NBROFADDRESSES": 2,
        /// "ADDRESS": [
        ///   {
        ///     "TYPE": "PERM",
        ///     "STATUS": "Valid",
        ///   },
        ///   {
        ///     "TYPE": "CACHE",
        ///     "STATUS": "Valid",
        ///   }
        ///  ],
        /// } 
        /// <param name="borrowerSummary">The json from the iseries web service</param>
        /// <returns>List of Addresses</returns>
        public static List<Address> GetAddressesFromJson(string borrowerSummary)
        {
            try
            {
                //Create the serializer with a custom resolver, and load the json into an object
                var settings = new JsonSerializerSettings { ContractResolver = new CustomAddressResolver() };
                var root = JObject.Parse(borrowerSummary);
               
                //Deserialize the Address array - this will use a custom resolver to deal with data types and name mismatches
                List<Address> addresses = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Address>>(root["ADDRESS"].ToString(), settings);

                //Set IsValid based on the Status property from the service
                // ** I could not figure out a way to do this in the newtonsoft resolvers **
                addresses.ForEach(p => p.IsValid = (p.Status.ToLower() == "valid" ? true : false));
                
                return addresses;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
