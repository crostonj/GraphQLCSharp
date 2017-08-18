using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nds.Borrower.GraphQl.Models
{
    public class SkipAddress
    {
        public string Ssn { get; set; }
        public decimal DateCreated { get; set; }
        public decimal TimeCreated { get; set; }
        public decimal Seq { get; set; }
        /// <summary>
        /// Valid Address
        /// Y/N
        /// </summary>
        public string ValidAddress { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string ForeignCountryIndicator { get; set; }
        public string AddresSource { get; set; }
        /// <summary>
        /// Date Address was set to invalid
        /// </summary>
        public decimal InvalidDate { get; set; }
        /// <summary>
        /// User that made address invalid
        /// </summary>
        public string InvalidByUserId { get; set; }
        public decimal IO_SV_ATTEMPT_DT { get; set; }
        public string IO_SV_CODE { get; set; }
        public decimal IO_SV_RESP_DT { get; set; }
        public string IO_SV_RESP_USER_ID { get; set; }
        public string IO_CD1A_DO_NOT_USE { get; set; }
        public string IO_INVOKE_TRACK { get; set; }
        /// <summary>
        /// Inactive Flag
        /// I: for Inactive
        /// </summary>
        public string InActive { get; set; }
        public string IO_RCD_CRT_CAMPAIGN { get; set; }
        public string SystemName { get; set; }
    }
}
