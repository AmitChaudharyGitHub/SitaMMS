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
    
    public partial class TbCashPurchaseChild
    {
        public decimal UId { get; set; }
        public Nullable<decimal> MUId { get; set; }
        public Nullable<int> SrNo { get; set; }
        public Nullable<int> ItemId { get; set; }
        public string Unit { get; set; }
        public string ItemGroup { get; set; }
        public Nullable<decimal> PurchaseQty { get; set; }
        public Nullable<decimal> Receive { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public string TaxType { get; set; }
        public Nullable<decimal> Vat { get; set; }
        public Nullable<decimal> Amount { get; set; }
    
        public virtual tblItemMaster tblItemMaster { get; set; }
        public virtual TbCashPurchaseMaster TbCashPurchaseMaster { get; set; }
    }
}
