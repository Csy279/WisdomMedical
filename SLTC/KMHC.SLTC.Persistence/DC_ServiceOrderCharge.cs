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
    
    public partial class DC_ServiceOrderCharge
    {
        public string ServiceOrderChargeRecId { get; set; }
        public Nullable<int> ServiceOrderID { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> FrontPreAmount { get; set; }
        public Nullable<decimal> PreAmount { get; set; }
        public Nullable<decimal> ReceiveAmount { get; set; }
        public Nullable<int> Operator { get; set; }
        public string Payer { get; set; }
        public string PaymentType { get; set; }
        public Nullable<System.DateTime> PayTime { get; set; }
        public string InvoiceNo { get; set; }
        public Nullable<int> ChargeStatus { get; set; }
        public string RefundReason { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
