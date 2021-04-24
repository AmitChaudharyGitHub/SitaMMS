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
    
    public partial class ns_tbl_IssueQuantity
    {
        public int Id { get; set; }
        public string ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string IndentNo { get; set; }
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string ItemGroupID { get; set; }
        public string ItemGroupName { get; set; }
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string UnitID { get; set; }
        public string Make { get; set; }
        public string PartNo { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> BalanceQuantity { get; set; }
        public Nullable<decimal> IssueQuantity { get; set; }
        public string SessionId { get; set; }
        public string SiteId { get; set; }
        public string IssuedBy { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<decimal> AvailableQuantity { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<decimal> AfterIssue_AvlQty_Stock { get; set; }
        public string PcContractorId { get; set; }
        public Nullable<System.DateTime> Issue_Date { get; set; }
        public Nullable<System.DateTime> Gate_ReceiveDate { get; set; }
        public Nullable<decimal> GateEntry_UId { get; set; }
        public Nullable<decimal> Receive_Rate { get; set; }
        public string Issue_Type { get; set; }
        public string Optional_Name { get; set; }
        public Nullable<int> Financial_Type { get; set; }
        public Nullable<bool> IsDebit_Note { get; set; }
        public Nullable<System.DateTime> DebitNote_Date { get; set; }
        public Nullable<int> BlockId { get; set; }
        public string BlockName { get; set; }
        public Nullable<int> FloorId { get; set; }
        public string FloorName { get; set; }
        public string IndentType { get; set; }
        public string IndentOtherDesc { get; set; }
        public string NatureOfWorkId { get; set; }
        public Nullable<decimal> ReturnQty { get; set; }
        public Nullable<System.DateTime> LastReturnDate { get; set; }
        public Nullable<int> MachineId { get; set; }
        public string IssueBill_No { get; set; }
        public string WorkTypeCode { get; set; }
    }
}