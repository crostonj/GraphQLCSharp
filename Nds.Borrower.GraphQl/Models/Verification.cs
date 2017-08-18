using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nds.Borrower.GraphQl.Models
{
    public class Verification
    {
        public string Ssn { get; set; }
        public string Category { get; set; }
        public decimal SystemDate { get; set; }
        public decimal SystemTime { get; set; }
        public decimal Sequence { get; set; }
        public decimal VerifiedDate { get; set; }
        public decimal VerifiedTime { get; set; }
        public string Username { get; set; }
        public string Source { get; set; }
        public string Scope { get; set; }
        public decimal CanceledDate { get; set; }
        public decimal CanceledTime { get; set; }
        public string CanceledBy { get; set; }
        public string SystemName { get; set; }
    }
}
