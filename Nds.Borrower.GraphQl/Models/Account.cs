using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nds.Borrower.GraphQl.Models
{
    public class Account
    {
        /// <summary>
        /// AccountId
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Payoff Balance
        /// </summary>
        public double PayoffBalance { get; set; }

        /// <summary>
        /// Principal Balance
        /// </summary>
        public double PrincipalBalance { get; set; }

        /// <summary>
        /// Interest Balance
        /// </summary>
        public double InterestBalance { get; set; }

        /// <summary>
        /// Fees Balance
        /// </summary>
        public double FeesBalance { get; set; }

        /// <summary>
        /// Daily Interest Amount
        /// </summary>
        public double DailyInterestAmount { get; set; }

        /// <summary>
        /// Delinquent Amoun
        /// </summary>
        public double DelinquentAmount { get; set; }

        /// <summary>
        /// Maximum Days Past Due
        /// </summary>
        public int MaximumDaysPastDue { get; set; }

        /// <summary>
        /// Ten Day payoff
        /// </summary>
        public double TenDayPayoffAmount { get; set; }

        public double LastPaymentAmount { get; set; }

        public DateTime LastPaymentDate { get; set; }

        public double RegularPayment { get; set; }
        /// <summary>
        /// Number of loans
        /// </summary>
        public double LoanCount { get; set; }
     
        public bool IsError { get; set; }
   
        public string SystemName { get; set; }
    }
}
