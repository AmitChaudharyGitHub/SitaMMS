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
    
    public partial class tblIntraTransferTaxableMaster
    {
        public decimal TransId { get; set; }
        public string ProjectId { get; set; }
        public string IntraTransferNumber { get; set; }
        public Nullable<decimal> IntraTransferMasterDocumentId { get; set; }
        public Nullable<System.DateTime> TransferDate { get; set; }
        public string TransferProjectId { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string SendTo { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public string PICApprovalId { get; set; }
        public string PICApprovalStatus { get; set; }
        public Nullable<System.DateTime> PICApprovalDate { get; set; }
        public string PICReamarks { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> SubTotal1 { get; set; }
        public Nullable<decimal> SubTotal2 { get; set; }
        public Nullable<decimal> GrandTotal { get; set; }
        public Nullable<decimal> Total_PAndF { get; set; }
        public Nullable<decimal> Total_Cartage { get; set; }
        public Nullable<decimal> Total_Insurance { get; set; }
        public Nullable<decimal> Total_Taxable { get; set; }
        public Nullable<decimal> Total_CGST { get; set; }
        public Nullable<decimal> Total_SGSTAndUTGST { get; set; }
        public Nullable<decimal> Total_IGST { get; set; }
        public string Total_NetAmountInWords { get; set; }
        public string TransferOutStatus { get; set; }
        public Nullable<System.DateTime> ReachingDateofDestination { get; set; }
        public Nullable<int> DivisionId { get; set; }
    }
}
