using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nds.Borrower.GraphQl.Models
{
    public class SkipPhone
    {
        public string Ssn { get; set; }
        public decimal DateCreated { get; set; }
        public decimal TimeCreated { get; set; }
        public decimal Seq { get; set; }
        //Consent Denied            N    
        //Consent Granted           Y    
        //Consent Unknown                
        public string CellPhoneConsent { get; set; }
        public string ForeignPhone { get; set; }
        public string IntenationalPhoneExchange { get; set; }
        public string AreaCode { get; set; }
        public decimal PhoneNumber { get; set; }
        public string PhoneExtension { get; set; }
        public string TimeZone { get; set; }
        public string CallTimeIndicator { get; set; }
        public string Source { get; set; }
        public string Contact { get; set; }
        public decimal LastCallDate { get; set; }
        /// <summary>
        /// Valid Phone
        /// Y/N/[Blank]
        /// </summary>
        public string ValidPhone { get; set; }
        /// <summary>
        /// Date phone was set to invalid
        /// </summary>
        public decimal InvalidDate { get; set; }
        /// <summary>
        /// User that made phone invalid
        /// </summary>
        public string InvalidByUserId { get; set; }
        public string SystemName { get; set; }
    }
}
