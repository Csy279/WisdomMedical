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
    
    public partial class DC_Resident
    {
        public DC_Resident()
        {
            this.DC_CheckRoomQueue = new HashSet<DC_CheckRoomQueue>();
            this.DC_ActivityNew = new HashSet<DC_ActivityNew>();
        }
    
        public int ResidentID { get; set; }
        public Nullable<int> OrganizationID { get; set; }
        public int PersonID { get; set; }
        public int AreaID { get; set; }
        public string Password { get; set; }
        public string ResidentNo { get; set; }
        public string Status { get; set; }
        public Nullable<int> Contract { get; set; }
        public Nullable<int> CarerID { get; set; }
        public System.DateTime CheckInDate { get; set; }
        public string Sex { get; set; }
        public string ResidentType { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedTime { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ICollection<DC_CheckRoomQueue> DC_CheckRoomQueue { get; set; }
        public virtual ICollection<DC_ActivityNew> DC_ActivityNew { get; set; }
    }
}
