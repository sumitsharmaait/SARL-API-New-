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
    
    public partial class usp_NewFormate_TransactionLogs_Download_Test_Result
    {
        public Nullable<int> TotalCount { get; set; }
        public long WalletTransactionId { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string servicename { get; set; }
        public string categoryname { get; set; }
        public string transactionid { get; set; }
        public string transactionType { get; set; }
        public string totalAmount { get; set; }
        public string commisionAmount { get; set; }
        public string walletAmount { get; set; }
        public string AccountNo { get; set; }
        public int transactionStatus { get; set; }
        public string comments { get; set; }
        public string name { get; set; }
        public long walletuserid { get; set; }
        public string ReceiverCountryName { get; set; }
        public string SenderCountryName { get; set; }
    }
}
