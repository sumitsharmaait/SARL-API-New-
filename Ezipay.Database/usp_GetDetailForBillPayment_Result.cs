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
    
    public partial class usp_GetDetailForBillPayment_Result
    {
        public long WalletUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StdCode { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public string Otp { get; set; }
        public string QrCode { get; set; }
        public Nullable<bool> IsOtpVerified { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public string CurrentBalance { get; set; }
        public Nullable<int> UserType { get; set; }
        public Nullable<long> AdminUserId { get; set; }
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }
        public Nullable<bool> IsEmailVerified { get; set; }
        public string HashedPassword { get; set; }
        public byte[] HashedSalt { get; set; }
        public string DeviceToken { get; set; }
        public Nullable<int> DeviceType { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public byte[] OtpHashedSalt { get; set; }
        public Nullable<bool> IsFirstTimeUser { get; set; }
        public Nullable<bool> IsTemporaryPassword { get; set; }
        public string ProfileImage { get; set; }
        public Nullable<bool> IsNotification { get; set; }
        public string EmailAuthToken { get; set; }
        public string UserAddress { get; set; }
        public Nullable<int> DocumetStatus { get; set; }
        public string Countries { get; set; }
        public Nullable<bool> IsDisabledTransaction { get; set; }
        public Nullable<int> MerchantType { get; set; }
        public string BusinessLicense { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public string TinNumber { get; set; }
        public string VatNumber { get; set; }
        public string PostalCode { get; set; }
        public Nullable<int> AppVersion { get; set; }
        public Nullable<decimal> EarnedPoints { get; set; }
        public Nullable<decimal> EarnedAmount { get; set; }
    }
}
