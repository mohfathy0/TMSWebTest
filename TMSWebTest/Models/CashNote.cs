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
    
    public partial class CashNote
    {
        public int Id { get; set; }
        public bool IsCashIn { get; set; }
        public string Code { get; set; }
        public int StoreId { get; set; }
        public byte PartType { get; set; }
        public int PartId { get; set; }
        public int DrawerId { get; set; }
        public double Amount { get; set; }
        public double DiscountValue { get; set; }
        public System.DateTime InserDate { get; set; }
        public string Notes { get; set; }
    }
}