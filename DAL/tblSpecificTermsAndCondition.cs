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
    
    public partial class tblSpecificTermsAndCondition
    {
        public int Id { get; set; }
        public string ProjectId { get; set; }
        public string Statement_Header { get; set; }
        public string STC_Description { get; set; }
        public string Company_Id { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string Isdeleted { get; set; }
        public string Purchase_Order_No { get; set; }
        public string ProjectName { get; set; }
    }
}
