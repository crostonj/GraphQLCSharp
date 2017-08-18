using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nds.Borrower.GraphQl.Models
{
    public class BorrowerHistory
    {

        public string SSN { get; set; }

        public decimal HistoryDate { get; set; }

        public decimal HistoryTime { get; set; }

        public decimal SequenceNumber { get; set; }

        public string HistoryType { get; set; }

        public string HistoryCode { get; set; }

        public string HistoryText { get; set; }

        public string UserId { get; set; }

        public string SystemName { get; set; }
    }
}
