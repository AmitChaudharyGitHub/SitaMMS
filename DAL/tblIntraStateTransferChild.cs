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
    
    public partial class tblIntraStateTransferChild
    {
        public decimal TransId { get; set; }
        public Nullable<decimal> IntraStateTransferMasterId { get; set; }
        public string IntraStateTransferNumber { get; set; }
        public string ProjectId { get; set; }
        public string ItemGroupId { get; set; }
        public string ItemId { get; set; }
        public string UnitId { get; set; }
        public Nullable<decimal> StockQty { get; set; }
        public Nullable<decimal> DeliveryQty { get; set; }
        public Nullable<decimal> BalancedQty { get; set; }
        public Nullable<decimal> DiscountedRate { get; set; }
        public Nullable<decimal> DeliveryRate { get; set; }
        public Nullable<decimal> EstimatedValue { get; set; }
    }
}
