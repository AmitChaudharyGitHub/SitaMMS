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
    
    public partial class TbIndentPurchaseOrderChild
    {
        public decimal UId { get; set; }
        public Nullable<decimal> MUId { get; set; }
        public Nullable<int> SrNo { get; set; }
        public string ItemNo { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> Receive { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> IndentId { get; set; }
        public Nullable<decimal> Vat { get; set; }
        public Nullable<decimal> SubTotal { get; set; }
        public string Remark { get; set; }
        public Nullable<decimal> PackingCharges { get; set; }
        public string ExciseDutyType { get; set; }
        public Nullable<decimal> ExcisepercentageAmt { get; set; }
        public Nullable<int> Cartage1_ID { get; set; }
        public Nullable<decimal> Cartage_rate { get; set; }
        public string Insurance1_Type { get; set; }
        public Nullable<decimal> Insurance1Amount { get; set; }
        public string Tax_Type { get; set; }
        public Nullable<decimal> Tax_Amount { get; set; }
        public Nullable<int> Cartage2_Id { get; set; }
        public Nullable<decimal> Cartage2_rate { get; set; }
        public string Insurance2_Type { get; set; }
        public Nullable<decimal> Insurance2_Amount { get; set; }
        public Nullable<decimal> PIQty { get; set; }
        public Nullable<decimal> CartageAmount { get; set; }
        public Nullable<decimal> CartageAmount2 { get; set; }
        public Nullable<decimal> RemOrApprovQty { get; set; }
        public Nullable<decimal> Item_TotalAmt { get; set; }
        public Nullable<decimal> Item_SubTotal1 { get; set; }
        public Nullable<decimal> Item_SubTotal2 { get; set; }
        public Nullable<decimal> Item_GrandTotal { get; set; }
        public string Item_description { get; set; }
        public string IsExcise { get; set; }
        public string IsInsurance1 { get; set; }
        public Nullable<decimal> Insurance1Rate { get; set; }
        public string IsCartage1 { get; set; }
        public string IsInsurance2 { get; set; }
        public Nullable<decimal> Insurance2Rate { get; set; }
        public string IsTax { get; set; }
        public Nullable<decimal> TaxPercentage { get; set; }
        public string IsInsurance3 { get; set; }
        public string Insurance3_Type { get; set; }
        public Nullable<decimal> Insurance3_Rate { get; set; }
        public Nullable<decimal> Insurance3_Amount { get; set; }
        public string IsCartage2 { get; set; }
        public string IsInsurance4 { get; set; }
        public string Insurance4_Type { get; set; }
        public Nullable<decimal> Insurance4_Rate { get; set; }
        public Nullable<decimal> Insurance4_Amount { get; set; }
        public Nullable<decimal> LastQty { get; set; }
    }
}
