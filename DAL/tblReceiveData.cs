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
    
    public partial class tblReceiveData
    {
        public decimal TransId { get; set; }
        public Nullable<int> ID { get; set; }
        public string IDType { get; set; }
        public string TypeNumber { get; set; }
        public Nullable<System.DateTime> TypeDate { get; set; }
        public Nullable<decimal> ReceiveQuantity { get; set; }
        public Nullable<decimal> IssueQuantity { get; set; }
        public Nullable<decimal> BalanceQuantity { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public string ProjectId { get; set; }
        public string ItemGroupId { get; set; }
        public string ItemId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<bool> Isdeleted { get; set; }
        public string FinYear { get; set; }
    }
}
