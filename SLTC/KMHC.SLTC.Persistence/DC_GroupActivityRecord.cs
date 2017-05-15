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
    
    public partial class DC_GroupActivityRecord
    {
        public int ID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<int> ItemID { get; set; }
        public string ActivityName { get; set; }
        public string ActivityContent { get; set; }
        public string ActivityPlace { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<decimal> Hours { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public string EmployeeIDs { get; set; }
        public string EmployeeNames { get; set; }
        public Nullable<int> EmployeeCount { get; set; }
        public string MemberIDs { get; set; }
        public string MemberNames { get; set; }
        public Nullable<int> MemberCount { get; set; }
        public string OtherPersons { get; set; }
        public Nullable<int> OtherCount { get; set; }
        public Nullable<int> AreaID { get; set; }
        public Nullable<int> OrganizationID { get; set; }
        public Nullable<int> CreateFromID { get; set; }
    
        public virtual DC_GroupActivityCategory DC_GroupActivityCategory { get; set; }
        public virtual DC_GroupActivityItem DC_GroupActivityItem { get; set; }
    }
}
