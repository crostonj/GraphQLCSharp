using System.Collections.Generic;
using System.Threading.Tasks;
using Nds.Borrower.Common.Entities;
using Nds.Borrower.GraphQl.Models;

namespace Nds.Borrower.GraphQl.Schema
{
    public class BorrowerData
    {
        private readonly List<Models.Borrower> _borrowers = new List<Models.Borrower>();
        

        public BorrowerData()
        {
            _borrowers.Add(new Models.Borrower
            {
                SSN = "111111111",
                FirstName = "Luke",
                LastName = "Skywalker"
                
            });
            _borrowers.Add(new Models.Borrower
            {
                SSN = "222222222",
                FirstName = "Luke",
                LastName = "Skywalker"
            });

            _borrowers.Add(new Models.Borrower
            {
                SSN = "333333333",
                FirstName = "R2",
                LastName = "D2"
            });
            _borrowers.Add(new Models.Borrower
            {
                SSN = "444444444",
                FirstName = "C",
                LastName = "3PO"
            });
        }
        

        public Task<Models.Borrower> GetBorrowerBySsnAsync(string ssn)
        {
            return BeaconResolvers.GetBorrowerBySsnAsync(ssn);
        }

        public List<Activity> GetBorrowerActivitiesBySsn(Models.Borrower borrower)
        {
            return BeaconResolvers.GetActivityBySsn(borrower.SSN);
        }

        public List<Address> GetBorrowerAddressesBySsn(Models.Borrower borrower)
        {
            return BeaconResolvers.GetAddressesBySsn(borrower.SSN);
        }
        public Task<Models.Borrower> AddHistoryNote(string ssn, string notetype, string notetext)
        {
            //Perform the update here

            //Return the borrower - any of the fields from the Borrower could be specified as the return query
            //  and GraphQl will resolve that just like on a regular query
            return BeaconResolvers.GetBorrowerBySsnAsync(ssn);
        }
    }
}
