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
    
    public partial class DC_CallInfo
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public Nullable<System.DateTime> CallDate { get; set; }
        public string CallCatagory { get; set; }
        public string CallType { get; set; }
        public string ReferralOrg { get; set; }
        public string Status { get; set; }
        public string Result { get; set; }
    }
}
