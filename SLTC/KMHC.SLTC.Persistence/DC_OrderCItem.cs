//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KMHC.SLTC.Persistence
{
    using System;
    using System.Collections.Generic;
    
    public partial class DC_OrderCItem
    {
        public int OrderCItemID { get; set; }
        public int ServiceOrderID { get; set; }
        public int CommodityItemID { get; set; }
        public string CINo { get; set; }
        public string CIName { get; set; }
        public string PhotoPath { get; set; }
        public string Unit { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> Quantity { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
