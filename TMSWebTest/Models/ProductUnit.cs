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
    
    public partial class ProductUnit
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UnitId { get; set; }
        public double Factor { get; set; }
        public double BuyPrice { get; set; }
        public double SellPrice { get; set; }
        public double SellDiscount { get; set; }
        public string Barcode { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
