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
    
    public partial class tblItemMasterStock
    {
        public int Id { get; set; }
        public string ItemGroup { get; set; }
        public string ItemNo { get; set; }
        public string ProjectNo { get; set; }
        public Nullable<int> Sesson { get; set; }
        public Nullable<int> Internal { get; set; }
        public string UnitId { get; set; }
        public Nullable<decimal> Opening { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<decimal> Closing { get; set; }
        public Nullable<decimal> SystemQty { get; set; }
        public Nullable<decimal> PhysicalQty { get; set; }
        public Nullable<decimal> DiffFromSystemQty { get; set; }
        public Nullable<decimal> WastagePercent { get; set; }
        public Nullable<decimal> WastageQty { get; set; }
        public Nullable<decimal> ActualQtyAfterWastage { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string OpeningType { get; set; }
        public Nullable<decimal> TotalPurchase { get; set; }
        public Nullable<decimal> TotalIssue { get; set; }
        public Nullable<decimal> TheoriticalQty { get; set; }
        public Nullable<decimal> PStockValue { get; set; }
        public Nullable<decimal> TStockValue { get; set; }
        public Nullable<decimal> DiffFromTheoritical { get; set; }
        public Nullable<decimal> LastOpening { get; set; }
        public Nullable<System.DateTime> OpeningDate { get; set; }
        public Nullable<System.DateTime> ClosingDate { get; set; }
        public Nullable<System.DateTime> CreatedDateNew { get; set; }
    }
}
