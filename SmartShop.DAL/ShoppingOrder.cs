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
    
    public partial class ShoppingOrder
    {
        public ShoppingOrder()
        {
            this.ShoppingOrderDetails = new HashSet<ShoppingOrderDetail>();
        }
    
        public int OrderID { get; set; }
        public Nullable<int> MemberID { get; set; }
        public string OrderCode { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<System.DateTime> RequiredDate { get; set; }
        public Nullable<System.DateTime> ShippedDate { get; set; }
        public Nullable<double> Total { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipCountry { get; set; }
        public Nullable<int> Status { get; set; }
    
        public virtual ICollection<ShoppingOrderDetail> ShoppingOrderDetails { get; set; }
    }
}
