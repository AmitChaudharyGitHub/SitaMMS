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
    
    public partial class ns_AddPriceCap
    {
        public int Id { get; set; }
        public string ProjectId { get; set; }
        public string ItemGroupId { get; set; }
        public string ItemId { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string EditedStatus { get; set; }
        public string RegionId { get; set; }
        public string EffectiveStatus { get; set; }
        public Nullable<System.DateTime> ValidUpto { get; set; }
    }
}
