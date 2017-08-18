using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nds.Borrower.GraphQl.Models
{
    public class Payment
    {
        public string Ssn { get; set; }
        public decimal EffectiveDate { get; set; }
        public decimal PostedDate { get; set; }
        public string LockboxSeqNumber { get; set; }
        public string LockboxSubSeqNumber { get; set; }
        public string GroupId { get; set; }
        public string LoanNumber { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal AllocationAmount { get; set; }
        public decimal AppliedInterest { get; set; }
        public decimal AppliedFees { get; set; }
        public decimal AppliedPrincipal { get; set; }
        public decimal AppliedRefund { get; set; }
        public string TransactionCode { get; set; }
        public string CancelReasonCode { get; set; }
        public string TransactionCodeDesc { get; set; }
        public decimal UnappliedPostDate { get; set; }
        public decimal UnappliedAmount { get; set; }
        public string UserId { get; set; }
        public string SystemName { get; set; }
    }
}
