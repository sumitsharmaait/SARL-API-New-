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
    
    public partial class Notification
    {
        public long NotificationId { get; set; }
        public Nullable<long> ReceiverId { get; set; }
        public Nullable<long> SenderId { get; set; }
        public string AlterMessage { get; set; }
        public string NotificationJson { get; set; }
        public Nullable<int> NotificationType { get; set; }
        public string DeviceToken { get; set; }
        public Nullable<int> DeviceType { get; set; }
        public Nullable<bool> IsRead { get; set; }
        public Nullable<bool> IsDelivered { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual WalletUser WalletUser { get; set; }
        public virtual WalletUser WalletUser1 { get; set; }
        public virtual WalletUser WalletUser2 { get; set; }
        public virtual WalletUser WalletUser3 { get; set; }
        public virtual WalletUser WalletUser4 { get; set; }
        public virtual WalletUser WalletUser5 { get; set; }
        public virtual WalletUser WalletUser6 { get; set; }
        public virtual WalletUser WalletUser7 { get; set; }
    }
}
