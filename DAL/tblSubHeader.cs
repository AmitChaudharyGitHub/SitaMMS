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
    
    public partial class tblSubHeader
    {
        public int STransId { get; set; }
        public Nullable<int> MainHeaderId { get; set; }
        public string SubHeaderName { get; set; }
        public string ProjectId { get; set; }
        public Nullable<bool> SubHeaderStatus { get; set; }
        public string CompanyId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> SubMenuOrder { get; set; }
    }
}
