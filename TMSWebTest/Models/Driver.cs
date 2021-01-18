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
    
    public partial class Driver
    {
        public int Id { get; set; }
        public string DriverName { get; set; }
        public string PassportNumber { get; set; }
        public Nullable<System.DateTime> PassportExpiryDate { get; set; }
        public string DrivingLicenseNumber { get; set; }
        public Nullable<System.DateTime> DrivingLicenseExpiryDate { get; set; }
        public string TachoCardNumber { get; set; }
        public Nullable<System.DateTime> TachoCardExpiryDate { get; set; }
        public string PhoneNumber { get; set; }
        public string ADRCertificateNumber { get; set; }
        public Nullable<System.DateTime> ADRCertificateExpiryDate { get; set; }
        public string CPCCardNumber { get; set; }
        public Nullable<System.DateTime> CPCCardExpiryDate { get; set; }
        public byte[] DriverDelegations { get; set; }
        public Nullable<bool> DrivingLicenseCategoryB { get; set; }
        public Nullable<bool> DrivingLicenseCategoryBE { get; set; }
        public Nullable<bool> DrivingLicenseCategoryC { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public string FirebaseDocumentId { get; set; }
        public string FirebaseDocumentRef { get; set; }
        public Nullable<bool> Archived { get; set; }
    }
}