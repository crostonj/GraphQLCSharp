using System;
using System.Collections.Generic;


namespace Nds.Borrower.GraphQl.Models
{
    
    public class Borrower : ICloneable 
    {
        
        public string SSN { get; set; }
       
        public string AccountId { get; set; }
       
        public string FirstName { get; set; }        
       
        public string LastName { get; set; }
        
        public string MiddleInitial { get; set; }

        public DateTime BirthDate { get; set; }
        
        /// <summary>
        /// Address status codes
        ///Both Addresses Bad      B    
        ///Good                           
        ///Legal                   L    
        ///Permanent Bad           P    
        ///Skip                    S    
        ///Temporary Bad           T    
        /// </summary>
        public string AddressStatus { get; set; }


        /// <summary>
        /// All borrower phone status
        /// </summary>
        /// All phones bad          A
        /// Good                    *blank*
        public string PhoneStatus { get; set; }

        public string CpcFlag { get; set; }

        /// <summary>
        /// Which address to use
        ///  Use Permanent             P  
        ///  Use Temporary             T  
        /// </summary>
        public string AddressToUse { get; set; }

        public string PermTimeZone { get; set; }

        public string PermAddressSource { get; set; }

        public string PermForeignCountry { get; set; }

        public string PermAddress1 { get; set; }

        public string PermAddress2 { get; set; }

        public string PermCity { get; set; }

        public string PermZipCode { get; set; }

        public string PermCountryCode { get; set; }

        public string PermStateCode { get; set; }

        public string PermCountry { get; set; }

        public string PermIntlPhoneExchnage { get; set; }

        public string PermAreaCode { get; set; }
        
        public decimal PermPhoneNumber { get; set; }
        
        public string PermPhoneExtension { get; set; }
        
        public string PermCallTimeInd { get; set; }
        
        public string PermForeignPhoneInd { get; set; }

        public string PermPhoneStatus { get; set; }
        
        public string TempTimeZone { get; set; }

        public string TempAddressSource { get; set; }

        public string TempForeignCountry { get; set; }

        public string TempAddress1 { get; set; }

        public string TempAddress2 { get; set; }

        public string TempCity { get; set; }

        public string TempZipCode { get; set; }

        public string TempCountryCode { get; set; }

        public string TempStateCode { get; set; }

        public string TempCountry { get; set; }

        public string TempIntlPhoneExchange { get; set; }

        public string TempAreaCode { get; set; }

        public decimal TempPhoneNumber { get; set; }

        public string TempPhoneExt { get; set; }

        public string TempCallTimeInd { get; set; }

        public string TempPhoneStatus { get; set; }

        public string TempForeignPhoneInd { get; set; }

        public string OtherPhoneInd { get; set; }

        public decimal OtherPhoneNumber { get; set; }

        public string OtherCallTimeInd { get; set; }

        public string OtherPhoneAreaCode { get; set; }

        public string OtherInPhoneExchange { get; set; }

        //Foreign Phone             Y 
        //Not Foreign                 
        public string OtherForeignPhoneInd { get; set; }

        public string OtherPhoneStatus { get; set; }

        public string LegalResidenceCountry { get; set; }

        public string LegalResidenceState { get; set; }

        public string CallNeededSW { get; set; }

        public string CallNeededUns { get; set; }

        public string SlSchoolCode { get; set; }

        public string SlBranch { get; set; }

        public decimal EnrollDate { get; set; }

        public string EnrolledStatus { get; set; }

        public decimal HalfOfMonthPD { get; set; }

        public string InsuredSW { get; set; }

        public decimal MaxNumDayPd { get; set; }

        public decimal NbrAttemptsPerCycle { get; set; }

        public decimal DaysSinceBadAddress { get; set; }

        public decimal GradSepDate { get; set; }

        public decimal OldestIntRatePIF { get; set; }

        public string PreviousSSN { get; set; }

        public string RecordLocked { get; set; }

        public string RecordLockedUns { get; set; }

        public string CallStatusOverride { get; set; }

        public decimal DaysPastDueUnin { get; set; }

        public string CorrPrintControl { get; set; }

        public decimal DateLastChanged { get; set; }

        public decimal TotalNbrOfLoans { get; set; }

        public string ContactInstructions { get; set; }

        public string LoanPosition { get; set; }

        public string Sex { get; set; }

        public string Race { get; set; }

        public decimal Dtee8pos { get; set; }

        public string DriversLicense { get; set; }

        public decimal ReturnedCheckCount { get; set; }

        public string Citizenship { get; set; }

        public string AlienIdNumber { get; set; }

        public decimal ArchiveDate { get; set; }

        public decimal SchoolCertDate { get; set; }

        public decimal LastSkipActivityDate { get; set; }

        public decimal SuppressonDate { get; set; }

        public decimal CreditScore { get; set; }

        public string LegalSubStatus { get; set; }

        public string EnrollmentSource { get; set; }

        public string SchoolDeferRequested { get; set; }

        public string IncentEligibility { get; set; }

        public string SpecialInstructCode { get; set; }

        public string CollectionGroup { get; set; }

        public string CollectorCode { get; set; }

        public string ChangedByUser { get; set; }

        public decimal DateRecordAdded { get; set; }

        public List<Address> Addresses { get; set; }

        public List<BeaconActivity> Activities { get; set; }

        public IEnumerable<Employer> Employers { get; set; }

        public List<BorrowerHistory> BorrowerHistories { get; set; }

        public List<Loan> Loans { get; set; }

        public List<Group> Groups { get; set; }

        /// <summary>
        /// Digital Records include emails
        /// </summary>
        public List<Digital> Digitals { get; set; }

        /// <summary>
        /// Skip Waterfall Addresses
        /// </summary>
        public List<SkipAddress> SkipAddresses { get; set; }

        /// <summary>
        /// Skip Waterfall Emails
        /// </summary>
        public List<SkipEmail> SkipEmails { get; set; }

        /// <summary>
        /// Skip Waterfall Phones
        /// </summary>
        public List<SkipPhone> SkipPhones { get; set; }

        /// <summary>
        /// Account Summary
        /// </summary>
        public Account Account { get; set; }

        public bool ECorrFlag;

        public bool ECorrOutOfSync;

        public bool KwikPayFlag;

        public bool KwikPayOutOfSync;

        public List<Verification> Verifications { get; set; }
        public List<Payment> Payments { get; set; }
        
        public string SystemName { get; set; }

        public string SystemPriority { get; set; }

        public TimeSpan FetchTimeSpan { get; set; }        

        public Borrower Clone() { return (Borrower)this.MemberwiseClone(); }
       object ICloneable.Clone() { return Clone(); }

        #region Unsed Columnns

        //public string BRG3ST { get; set; }
        //public string BRG4ST { get; set; }
        //public string BRG5ST { get; set; }
        //public string BRGLCD { get; set; }
        //public string BRPXSR { get; set; }
        //public string BRPYSR { get; set; }
        //public string BRPZSR { get; set; }
        //public string BRP1SR { get; set; }
        //public string BRG8ST { get; set; }
        //public string BRG9ST { get; set; }
        //public string BRWQCF { get; set; }
        //public string BRWRCF { get; set; }
        //public string BRWSCF { get; set; }
        //public string BRWTCF { get; set; }
        //public string BRWUCF { get; set; }
        //public string BRWVCF { get; set; }
        //public string BRWWCF { get; set; }
        //public string BRWXCF { get; set; }
        //public string BRWYCF { get; set; }
        //public string BRWZCF { get; set; }
        //public string BRW0CF { get; set; }
        //public string BRW1CF { get; set; }
        //public string BRW2CF { get; set; }
        //public string BRW3CF { get; set; }
        //public string BRW4CF { get; set; }
        //public string BRGNCD { get; set; }
        //public string BRXHCF { get; set; }
        //public string BRBPZE { get; set; }
        //public string BRBTZE { get; set; }
        //public string BRGPCD { get; set; }
        //public string BRXLCF { get; set; }
        //public string BRWOCF { get; set; }
        //public decimal BRBNB2 { get; set; }
        //public decimal BRI1NB { get; set; }
        //public decimal BRI2NB { get; set; }
        //public decimal BRI3NB { get; set; }
        //public decimal BRWHNR { get; set; }
        //public decimal BRP9VA { get; set; }
        //public decimal BRQAVA { get; set; }
        //public decimal BRBWVL { get; set; }
        //public decimal BRQBVA { get; set; }
        //public decimal BRQCVA { get; set; }
        //public decimal BRBVVL { get; set; }
        //public decimal BRQHVA { get; set; }
        //public decimal BRQIVA { get; set; }
        
        //public decimal BRQEVA { get; set; }
        //public decimal BRQJVA { get; set; }
        //public decimal BRBRV1 { get; set; }
        //public decimal BRJGVM { get; set; }
        //public decimal BRJHVM { get; set; }
        //public decimal BRJIVM { get; set; }
        //public decimal BRQFVA { get; set; }
        //public decimal BRQGVA { get; set; }
        //public decimal BRCUDA { get; set; }
        //public decimal BRCVDA { get; set; }
        //public decimal BRCXDA { get; set; }
        //public decimal BRCYDA { get; set; }
        //public decimal BRCZDA { get; set; }
        //public decimal BRC0DA { get; set; }
        //public decimal BRC1DA { get; set; }
        //public decimal BRC2DA { get; set; }
        //public decimal BRC3DA { get; set; }
        //public decimal BRC4DA { get; set; }
        //public decimal BRC5DA { get; set; }
        //public decimal BRC6DA { get; set; }
        //public decimal BRC7DA { get; set; }
        //public decimal BRC8DA { get; set; }
        //public string BRHKTX { get; set; }
        //public string BRMHST { get; set; }
        //public string BRJBCD { get; set; }
        //public string BRJCCD { get; set; }
        //public decimal BRGBDT { get; set; }
        //public string BRJDCD { get; set; }
        //public string BRMIST { get; set; }
        //public decimal BRGEDT { get; set; }
        //public string BRMJST { get; set; }
        //public string BRMKST { get; set; }
        //public string BRMLST { get; set; }
        //public decimal BRGFDT { get; set; }
        //public decimal BRGGDT { get; set; }
        //public string BRMMST { get; set; }
        //public string BRMNST { get; set; }
        //public string BRMOST { get; set; }
        //public string BRMPST { get; set; }
        //public string BRMQST { get; set; }
        //public string BRMRST { get; set; }
        //public decimal BRPENB { get; set; }
        //public decimal BRPFNB { get; set; }
        //public decimal BRWINR { get; set; }
        //public decimal BRBXVL { get; set; }
        //public decimal BRBYVL { get; set; }
        //public decimal BRBZVL { get; set; }
        //public decimal BRB0VL { get; set; }
        //public decimal BRB1VL { get; set; }
        //public decimal BRB2VL { get; set; }
        //public decimal BRB3VL { get; set; }
        //public decimal CustDtec { get; set; }
        //public string BRFIUX { get; set; }

        #endregion
        
    }
}
