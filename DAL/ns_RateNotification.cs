//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MMS.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ns_RateNotification
    {
        public int Id { get; set; }
        public string SendBy { get; set; }
        public string ForwordTo { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public string Remark { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string ReforwordBy { get; set; }
        public string Status { get; set; }
    }
}
