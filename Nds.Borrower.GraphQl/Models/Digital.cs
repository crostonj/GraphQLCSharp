using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nds.Borrower.GraphQl.Models
{
    public class Digital
    {
        public string SSN { get; set; }
        public string EmailReferenceIndicator { get; set; }
        public decimal OC_EDR_REF_NUMBER { get; set; }
        public decimal OC_SEQ_NUMBER { get; set; }
        public decimal LN_NUM { get; set; }
        public decimal DB_DISB_NUMBER { get; set; }
        public string EmailAddress { get; set; }
        public string EmailIndicator { get; set; }
        public string EmailStatus { get; set; }
        public DateTime LastChangeDate { get; set; }
        public string SystemName { get; set; }
    }
}
