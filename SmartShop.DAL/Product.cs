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
    
    public partial class Product
    {
        public int ProductID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string NoSymbolName { get; set; }
        public Nullable<int> ProductSetID { get; set; }
        public Nullable<int> ProductGroupID { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<int> SizeID { get; set; }
        public int Viewed { get; set; }
        public Nullable<int> Available { get; set; }
    }
}
