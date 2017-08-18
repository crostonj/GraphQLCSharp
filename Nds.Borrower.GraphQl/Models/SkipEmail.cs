using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nds.Borrower.GraphQl.Models
{
    public class SkipEmail
    {
        public string Ssn { get; set; }
        public decimal DateCreated { get; set; }
        public decimal TimeCreated { get; set; }
        public decimal Seq { get; set; }
        public string EmailAddress { get; set; }
        public string Contact { get; set; }
        public decimal LastContactDate { get; set; }
        /// <summary>
        /// Valid Email
        /// Y/N
        /// </summary>
        public string ValidEmail { get; set; }
        /// <summary>
        /// Date email was set to invalid
        /// </summary>
        public decimal InvalidDate { get; set; }
        /// <summary>
        /// User that made email invalid
        /// </summary>
        public string InvalidByUserId { get; set; }
        public decimal NF_SV_ATTEMPT_DT { get; set; }
        public string NF_SV_CODE { get; set; }
        public decimal NF_SV_RESP_DT { get; set; }
        public string NF_SV_RESP_USER_ID { get; set; }
        public string SystemName { get; set; }
    }
}
