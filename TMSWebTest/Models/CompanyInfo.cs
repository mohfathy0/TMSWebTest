namespace TMSWebTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyInfo")]
    public partial class CompanyInfo
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string VAT_NIP { get; set; }

        public string Phone { get; set; }

        public string Mobile { get; set; }

        public string Address { get; set; }

        public string Website { get; set; }

        public string Email { get; set; }

        public string Branch { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public int AccountId { get; set; }

        public string Notes { get; set; }

        [Column(TypeName = "image")]
        public byte[] Logo { get; set; }
    }
}
