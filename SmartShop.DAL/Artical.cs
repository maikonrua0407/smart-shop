//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartShop.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Artical
    {
        public int ArticalID { get; set; }
        public int ArticalCatID { get; set; }
        public string Title { get; set; }
        public string Summery { get; set; }
        public string ArticalContent { get; set; }
        public string MasterImage { get; set; }
        public string ResizeImage { get; set; }
        public string Member { get; set; }
        public Nullable<System.DateTime> PublishDate { get; set; }
        public int Viewed { get; set; }
        public string Tag { get; set; }
        public bool Active { get; set; }
        public Nullable<bool> IsFix { get; set; }
    }
}
