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
    
    public partial class usp_DownloadMerchantList_Result
    {
        public Nullable<int> TotalCount { get; set; }
        public long MerchantId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string Password { get; set; }
        public string Company { get; set; }
        public string IsdCode { get; set; }
        public string Address { get; set; }
        public string LogoUrl { get; set; }
        public string MobileNoWithIsd { get; set; }
        public Nullable<decimal> CommissionPercent { get; set; }
        public Nullable<decimal> MerchantAmount { get; set; }
        public Nullable<decimal> PaidToEzeepay { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<bool> IsDisabledTransaction { get; set; }
    }
}
