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
    
    public partial class tbl_beforPIdecesionPurchase
    {
        public int TransId { get; set; }
        public string ProjectId { get; set; }
        public string PurReqNo { get; set; }
        public Nullable<int> Purchase_PI_DecesionType { get; set; }
        public Nullable<int> Purchase_PIC_DecesionType { get; set; }
        public Nullable<int> Purchase_Mang_DecesionType { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}
