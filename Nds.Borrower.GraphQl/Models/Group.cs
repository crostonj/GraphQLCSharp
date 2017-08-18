using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nds.Borrower.GraphQl.Models
{
    public class Group
    {
        public string AccountNumber { get; set; }
        public string SSN { get; set; }
        public string GroupId { get; set; }
        public string LenderId { get; set; }
        public decimal CoNumber { get; set; }
        public string GaId { get; set; }
        public string LoanType { get; set; }
        public string LoanStatus { get; set; }
        public string LoanStatusDescription { get; set; }
        public decimal InterestRate { get; set; }
        public string PostDefermentGrace { get; set; }
        public decimal GradSepDate { get; set; }
        public decimal ChangeIntRate { get; set; }
        public decimal ChangeIntDate { get; set; }
        public decimal ALetterDate { get; set; }
        public decimal AmoritzationInterest { get; set; }
        public decimal BLetterDate { get; set; }
        public string ClaimCode { get; set; }
        public DateTime ClaimDate { get; set; }
        public string ClaimRejectCode { get; set; }
        public DateTime ConversionDate { get; set; }
        public decimal DaysPastDue { get; set; }
        public decimal LastDPD { get; set; }
        public DateTime DisclosureDate { get; set; }
        public string DisclosurePrintSW { get; set; }
        public DateTime DueDate { get; set; }
        public decimal FinalPmtAmt { get; set; }
        public string InsuredSts { get; set; }
        public decimal LastPmtAmt { get; set; }
        public DateTime LastPmtDate { get; set; }
        public decimal LengthOfGrace { get; set; }
        public decimal MonthlyPmtAmtCurr { get; set; }
        public decimal MonthlyPmtAmtOrig { get; set; }
        public decimal NumTermPeriodsOrig { get; set; }
        public decimal NumTermPeriodRemain { get; set; }
        public decimal LPFNumTermPsRemain { get; set; }
        public decimal PartialPmtAmt { get; set; }
        public DateTime RCADate { get; set; }
        public string RCAStatus { get; set; }
        public decimal RefundAmt { get; set; }
        public DateTime RefundDate { get; set; }
        public decimal AmortizationCandidate { get; set; }
        public decimal GradPmtMths { get; set; }
        public string ClaimType { get; set; }
        public DateTime DefForbStartDate { get; set; }
        public decimal FirstPmtDue { get; set; }
        public decimal InactiveLoanTermPer { get; set; }
        public decimal FullPmtsWhileUnins { get; set; }
        public decimal PmtAmtWhileUnins { get; set; }
        public string LastStatus { get; set; }
        public decimal PmtsWhileUnins { get; set; }
        public decimal AmtOfPmtsDuringMth { get; set; }
        public decimal LastBilling { get; set; }
        public decimal LastActivity { get; set; }
        public string ActiveInactiveFlag { get; set; }
        public string PrintEndorserSTME { get; set; }
        public string IncentiveCalcMethod { get; set; }
        public string ComakerSSN { get; set; }
        public string SecondComakerSSN { get; set; }
        public string PmtSchedule { get; set; }
        public string PmtSchedule2ndInd { get; set; }
        public decimal NbrOfPmts { get; set; }
        public decimal GradPmtPctIncr { get; set; }
        public decimal LateCharges { get; set; }
        public DateTime GradPmtIncreaseDate { get; set; }
        public DateTime IncomeEvaluationDate { get; set; }
        public DateTime PDGEndDate { get; set; }
        public decimal LastBackingDteInGH { get; set; }
        public DateTime VerificationDate { get; set; }
        public string FinalDemandSentSw { get; set; }
        public decimal AchAlternateAmount { get; set; }
        public string SystemName { get; set; }
        public int ActiveLoanCount { get; set; }
        public decimal DelinquentAmount { get; set; }
        public Nullable<DateTime> IDRRecertificationDate { get; set; }
        public bool IdrIsPermStandard { get; set; }
        public Lender Lender { get; set; }
    }
}
