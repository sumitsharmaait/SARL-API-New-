//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ezipay.Database
{
    using System;
    
    public partial class usp_PaymentTransactions_NewApp1_Result
    {
        public int Id { get; set; }
        public Nullable<int> TotalCount { get; set; }
        public string RowLabel { get; set; }
        public Nullable<long> WalletTransactionId { get; set; }
        public string ServiceName { get; set; }
        public string SubCategory { get; set; }
        public string MainCategory { get; set; }
        public Nullable<long> receiverId { get; set; }
        public Nullable<long> senderId { get; set; }
        public string TransactionType { get; set; }
        public Nullable<int> TransactionCode { get; set; }
        public string Comments { get; set; }
        public string BankTransactionId { get; set; }
        public string CreatedDate { get; set; }
        public string WalletAmount { get; set; }
        public string TransactionAmount { get; set; }
        public string CommisionAmount { get; set; }
        public string MerchantCommissionAmount { get; set; }
        public string TotalAmount { get; set; }
        public Nullable<int> TransactionStatus { get; set; }
        public string FromMobileNo { get; set; }
        public string ToMobileNo { get; set; }
        public string AccountNo { get; set; }
        public Nullable<int> TransactionTypeInfo { get; set; }
        public Nullable<int> DataType { get; set; }
        public Nullable<int> SenderUserType { get; set; }
        public Nullable<int> ReceiverUserType { get; set; }
        public string DisplayContent { get; set; }
        public string TxnCountry { get; set; }
    }
}
