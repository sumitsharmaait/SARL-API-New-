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
    using System.Collections.Generic;
    
    public partial class ViewVerificationMail
    {
        public Nullable<long> RowNo { get; set; }
        public string EmailId { get; set; }
        public long EmailVerificationId { get; set; }
        public Nullable<long> WalletUserId { get; set; }
        public Nullable<bool> IsVerified { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> VerificationDate { get; set; }
        public Nullable<bool> IsMailSent { get; set; }
    }
}
