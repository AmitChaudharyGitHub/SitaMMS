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
    
    public partial class tblLogInformation
    {
        public int TransId { get; set; }
        public string CompanyID { get; set; }
        public string PRJID { get; set; }
        public string UserId { get; set; }
        public Nullable<System.DateTime> LogInTime { get; set; }
        public Nullable<System.DateTime> LogOutTime { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> LogActivity { get; set; }
    }
}
