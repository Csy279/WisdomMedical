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
    
    public partial class DC_ServiceGroup
    {
        public DC_ServiceGroup()
        {
            this.DC_SerGrpSerIt = new HashSet<DC_SerGrpSerIt>();
        }
    
        public int ServiceGroupID { get; set; }
        public int OrganizationID { get; set; }
        public string SGNo { get; set; }
        public string SGName { get; set; }
        public Nullable<decimal> InitPrice { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public decimal SumPrice { get; set; }
        public Nullable<int> ExpiryDate { get; set; }
        public string ExpiryUnit { get; set; }
        public string Photo { get; set; }
        public string Remark { get; set; }
        public string Description { get; set; }
        public Nullable<int> Hot { get; set; }
        public string ServiceGroupBelong { get; set; }
        public string Status { get; set; }
        public Nullable<int> OrderNum { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedTime { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ICollection<DC_SerGrpSerIt> DC_SerGrpSerIt { get; set; }
    }
}
