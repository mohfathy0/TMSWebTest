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
    
    public partial class UserLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public System.DateTime ActionDate { get; set; }
        public int ScreenId { get; set; }
        public byte ActionType { get; set; }
        public int PartId { get; set; }
        public string PartName { get; set; }
    }
}
