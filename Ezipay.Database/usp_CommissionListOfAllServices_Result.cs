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
    
    public partial class usp_CommissionListOfAllServices_Result
    {
        public int WalletServiceId { get; set; }
        public long ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string WalletServiceName { get; set; }
        public decimal Percentage { get; set; }
        public decimal FlatCharges { get; set; }
        public decimal BenchmarkCharges { get; set; }
        public decimal VATCharges { get; set; }
        public string BankCode { get; set; }
        public bool IsActive { get; set; }
        public Nullable<long> MerchantId { get; set; }
        public string IsdCode { get; set; }
    }
}
