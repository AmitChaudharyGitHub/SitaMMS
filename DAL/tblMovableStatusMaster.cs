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
    
    public partial class tblMovableStatusMaster
    {
        public int TransID { get; set; }
        public string MovingType { get; set; }
        public string MaxMonth { get; set; }
        public string MinMonth { get; set; }
        public string CreatedBy { get; set; }
        public string IsActive { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
