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
    
    public partial class CurrencyRate
    {
        public int Id { get; set; }
        public Nullable<decimal> DollarRate { get; set; }
        public Nullable<decimal> CediRate { get; set; }
        public Nullable<decimal> CfaRate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<decimal> NGNRate { get; set; }
        public Nullable<decimal> EuroRate { get; set; }
        public Nullable<decimal> SendNGNRate { get; set; }
        public Nullable<decimal> SendGHRate { get; set; }
    }
}
