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
    
    public partial class tblMMSUserPermission
    {
        public int TransId { get; set; }
        public Nullable<int> MainHeaderId { get; set; }
        public Nullable<bool> MainHeaderStatus { get; set; }
        public Nullable<int> SubHeaderId { get; set; }
        public Nullable<bool> SubHeaderStatus { get; set; }
        public string ProjectId { get; set; }
        public string UserId { get; set; }
        public Nullable<bool> PageStatus { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CompanyId { get; set; }
    }
}