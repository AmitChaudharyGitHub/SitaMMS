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
    
    public partial class tblMMSQuotation
    {
        public int TransId { get; set; }
        public string PurchaseReqNo { get; set; }
        public Nullable<decimal> UID { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ProjectId { get; set; }
        public string QuotationStatus { get; set; }
        public Nullable<decimal> TotalItemValue { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string QuotationRefNo { get; set; }
        public string Remarks { get; set; }
    }
}
