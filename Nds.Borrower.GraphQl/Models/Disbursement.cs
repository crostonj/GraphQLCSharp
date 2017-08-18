

namespace Nds.Borrower.GraphQl.Models
{
   public class Disbursement
    {
        public string SSN { get; set; }
        public decimal LoanNumber { get; set; }
        public decimal DisbNumber { get; set; }
        public decimal DisbSeq { get; set; }
        public string LenderId { get; set; }
        public string FeeRespLdLenderID { get; set; }
        public string MadeByLdLenderID { get; set; }
        public string RiskFeeRespLdLenderI { get; set; }
        public string ReasonCode { get; set; }
        public string CancelLenderId { get; set; }
        public string DisbStatus { get; set; }
        public decimal DbDate { get; set; }
        public decimal PrinAmount { get; set; }
        public decimal PostDate { get; set; }
        public decimal CancelDate { get; set; }
        public string ByUser { get; set; }
        public string CancelledByUser { get; set; }
        public decimal GuaranteedGrossAmt { get; set; }
        public string EFTIndicator { get; set; }
        public string BankId { get; set; }
        public string BankAccount { get; set; }
        public string CheckNumber { get; set; }
        public decimal InsurFee { get; set; }
        public decimal OrigFee { get; set; }
        public decimal InsuranceRate { get; set; }
        public decimal OriginationRate { get; set; }
        public decimal LenderRiskRate { get; set; }
        public decimal LenderRiskFee { get; set; }
        public string AccountingStage { get; set; }
        public string PostingStatus { get; set; }
        public string PromissoryNote { get; set; }
        public decimal PromissoryNoteDate { get; set; }
        public decimal PromissoryReturnedDt { get; set; }
        public decimal PurchaseDate { get; set; }
        public decimal PrinPurchased { get; set; }
        public decimal IntPurchased { get; set; }
        public decimal CapdIntPurchased { get; set; }
        public decimal CheckEFTDate { get; set; }
        public decimal CheckCashedDate { get; set; }
        public decimal AdjustDate { get; set; }
        public decimal BNbr { get; set; }
        public string Sts2z { get; set; }
        public string OrigFeeResp { get; set; }
        public string InsFeeResp { get; set; }
        public string RiskFeeResp { get; set; }
        public decimal PostedDate { get; set; }
        public decimal LockboxSeqNbr { get; set; }
        public decimal LockboxSubSeqNbr { get; set; }
        public string CancelSource { get; set; }
        public string PostSource { get; set; }

    }
}
