using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nds.Borrower.GraphQl.Models
{
    public class Employer
    {

        public string Ssn { get; set; }

        public string BorEdrRefInd { get; set; }

        public decimal EdrRefNumber { get; set; }

        public decimal SeqNumber { get; set; }

        public string CompanyName { get; set; }

        public string Occupation { get; set; }

        public string AddressStatus { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string CountryCode { get; set; }

        public string StateCode { get; set; }

        public string ZipCode { get; set; }

        public string PhoneStatus { get; set; }

        public string AreaCode { get; set; }

        public decimal PhoneNumber { get; set; }

        public string PhoneNumberExt { get; set; }

        public string IntnatlPhExchg { get; set; }

        public string CallTimeInd { get; set; }

        public string TimeZone { get; set; }

        public string EmailAddress { get; set; }

        public string EmailStatus { get; set; }

        public string SupervisorName { get; set; }

        public string SupervisorContactSw { get; set; }

        public string SupvPhoneStatus { get; set; }

        public string SupvAreaCode { get; set; }

        public decimal SupervisorPhone { get; set; }

        public string SupervisorPhoneExt { get; set; }

        public string SupvIntnatlPhExchg { get; set; }

        public string SupvEmailAddress { get; set; }

        public string SupvEmailStatus { get; set; }

        public decimal EmploymentEndDate { get; set; }

        public string SystemName { get; set; }
    }
}
