//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TMSWebTest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvoiceHeader
    {
        public int Id { get; set; }
        public byte InvoiceType { get; set; }
        public string Code { get; set; }
        public byte PartyType { get; set; }
        public int PartyId { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public System.DateTime IssueDate { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public int Branch { get; set; }
        public Nullable<System.DateTime> PosteDate { get; set; }
        public bool PostedToStore { get; set; }
        public double TotalLocal { get; set; }
        public double Total { get; set; }
        public double DiscountValue { get; set; }
        public double DiscountRatio { get; set; }
        public double TaxValue { get; set; }
        public double TaxRatio { get; set; }
        public double Expenses { get; set; }
        public double Net { get; set; }
        public double Paid { get; set; }
        public string Currency { get; set; }
        public int Drawer { get; set; }
        public double Remaining { get; set; }
        public string ShippingAddress { get; set; }
        public string Notes { get; set; }
        public Nullable<byte> SourceType { get; set; }
        public Nullable<int> SourceId { get; set; }
    }
}