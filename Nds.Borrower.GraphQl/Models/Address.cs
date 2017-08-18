using GraphQL.Types;
using System;

namespace Nds.Borrower.GraphQl.Models
{
    public class Address : ObjectGraphType
    {
        //From system i REST call GetBorrowerAddress
        public string Address3 { get; set; }
        public string Campaign { get; set; }
        public string InvalidByUserId { get; set; }
        public DateTime InvalidDate { get; set; }
        public string InvokeTrack { get; set; }
        public int SequenceNumber { get; set; }
        public DateTime ServiceAttemptDate { get; set; }
        public string ServiceCode { get; set; }
        public DateTime ServiceResponseDate { get; set; }
        public string ServiceResponseUser { get; set; }
        public string Source { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }


        //From AddressDetail in Nds.Borrower.Common
        public string Id { get; set; }
        public DateTime AddDate { get; set; }
        public string SystemName { get; set; }
        public string EntityState { get; set; }
        public DateTime LastUpdated { get; set; }

        //From Address
        public bool IsActive { get; set; }
        public bool IsValid { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public char AddressStatus { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string County { get; set; }
        public string ZipCode { get; set; }
        public string CountryCode { get; set; }
        public string ForeignCountryIndicator { get; set; }
    }
}
