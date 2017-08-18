using System.Collections.Generic;


namespace Nds.Borrower.GraphQl.Models
{
   
    public class Loan
    {

        public string AccountNumber { get; set; }

        public string SSN { get; set; }

        public decimal LoanNum { get; set; }

        public string LoanType { get; set; }

        public string Status { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string MiddleInitial { get; set; }

        public string BenefitingStudentSSN { get; set; }

        public string ComakerSSN { get; set; }

        public string SecondComaker { get; set; }

        public string LenderId { get; set; }

        public string GroupId { get; set; }

        public decimal CoNumber { get; set; }

        public decimal SecondaryCoNumber { get; set; }

        public string GaID { get; set; }

        public string SchoolCode { get; set; }

        public string SlBranch { get; set; }

        public string CountryCode { get; set; }

        public string StateCode { get; set; }

        public string County { get; set; }

        public decimal InterestRate { get; set; }

        public string PostDefermentGrace { get; set; }

        public decimal GradSepDate { get; set; }

        public decimal FirstDisbDate { get; set; }

        public decimal AmtDisb { get; set; }

        public decimal CappedInterestLTD { get; set; }

        public decimal ConversionDate { get; set; }

        public decimal CurrFees { get; set; }

        public decimal CurrInterest { get; set; }

        public decimal CurrPrincipal { get; set; }

        public decimal DailyInterestAmt { get; set; }

        public decimal FeesDueOrig { get; set; }

        public decimal FeesPaid { get; set; }

        public string GovtSubsidySts { get; set; }

        public decimal GrDueDate { get; set; }

        public decimal GradeLevel { get; set; }

        public decimal GuaranteeDate { get; set; }

        public string InactiveActiveSts { get; set; }

        public string InsuredSts { get; set; }

        public decimal InterestRateGovt { get; set; }

        public decimal ChangeIntDate { get; set; }

        public decimal ChangeIntRate { get; set; }

        public string InterestRateVarSW { get; set; }

        public decimal LengthOfGrace { get; set; }

        public decimal OrigLoanedAmt { get; set; }

        public decimal OrigLoanTerm { get; set; }

        public decimal OrigPrinPurchased { get; set; }

        public decimal AccrGovtIntPrevQtr { get; set; }

        public decimal AccrGovtIntCurrQTD { get; set; }

        public decimal BondNumber { get; set; }

        public decimal BuyDate { get; set; }

        public decimal InterestStartDate { get; set; }

        public decimal PaidFeeYTD { get; set; }

        public decimal PaidFeeBorrPrevYTD { get; set; }

        public decimal PaidIntBorrLTD { get; set; }

        public decimal PaidIntBorrYTD { get; set; }

        public decimal PaidIntBorrPrevYTD { get; set; }

        public decimal PaidIntTotalLTD { get; set; }

        public decimal PaidIntTotalYTD { get; set; }

        public decimal PaidPrinBorrLTD { get; set; }

        public decimal PaidPrinBorrYTD { get; set; }

        public decimal PaidPrinBorrYTDPrv { get; set; }

        public decimal PaidPrinTotalLTD { get; set; }

        public decimal PaidPrinTotalYTD { get; set; }

        public decimal PeriodEndingDate { get; set; }

        public decimal PeriodStartingDate { get; set; }

        public string PrevSystemID { get; set; }

        public string PrevLenderID { get; set; }

        public decimal RefundAmount { get; set; }

        public decimal RefundDate { get; set; }

        public decimal LateCharges { get; set; }

        public decimal LateChargesPaidLTD { get; set; }

        public decimal LateChargesPaidYTD { get; set; }

        public decimal LateChrgsPdPrevYTD { get; set; }

        public decimal SellDate { get; set; }

        public string NewLender { get; set; }

        public decimal NewBondNumber { get; set; }

        public string SpecialAllowanceCode { get; set; }
        
         public decimal SpecialAllowChgDate { get; set; }

        public string DiscloseRequiredSw { get; set; }

        public string DeferEligibility { get; set; }

        public decimal PDGEndDate { get; set; }

        public decimal BackingDateLimit { get; set; }

        public decimal LHWorkDisbAmt { get; set; }

        public decimal CurrentLoanedAmt { get; set; }

        public decimal NumSADays { get; set; }

        public decimal RemainingTermLength { get; set; }

        public string DeferIntAccrualSw { get; set; }

        public decimal Rebate { get; set; }

        public string PromissoryNote { get; set; }

        public decimal PromissoryNoteDate { get; set; }

        public decimal PromissoryReturnedDt { get; set; }

        public decimal PIFDate { get; set; }

        public decimal PaymentAllocation { get; set; }

        public string IncentiveElectionInd { get; set; }

        public string PIFSwitch { get; set; }

        public string FirstLoan { get; set; }

        public string ConsUnsubLoans { get; set; }

        public string RegionCode { get; set; }

        public string Cde8a { get; set; }

        public string InterestRateCode { get; set; }

        public decimal LTRStartingNumber { get; set; }

        public decimal JudgementRate { get; set; }

        public decimal MaxIntRate { get; set; }

        public decimal SchoolRefNoCancel { get; set; }

        public decimal IntRateReduction { get; set; }

        public string SuspendedSAFlag { get; set; }

        public string AnnualIncentiveSw { get; set; }

        public string NewResponsibleLender { get; set; }

        public string ProcureStatus { get; set; }

        public string SuspendedIntFlag { get; set; }

        public decimal TrackingValue { get; set; }

        public decimal CheckEFTDate { get; set; }

        public decimal ApplicationDate { get; set; }

        public decimal RehabDate { get; set; }

        public decimal LTDOtherIRAmts { get; set; }

        public decimal LTDBankDraftIRAmts { get; set; }

        public string GuaranteeLoanId { get; set; }

        public string AcademicYear { get; set; }

        public string NSLDSLoanId { get; set; }

        public string OrigMUKey { get; set; }

        public string CMLUniqueLoanId { get; set; }

        public string ConsumerInfoInd { get; set; }

        public string CmpCndCode { get; set; }

        public decimal FiscalYear { get; set; }

        public string IsPlusConsol { get; set; }

        public string IsSpousalConsol { get; set; }

        public List<Disbursement> Disbursements { get; set; }

        public string SystemName { get; set; }

    }
}
