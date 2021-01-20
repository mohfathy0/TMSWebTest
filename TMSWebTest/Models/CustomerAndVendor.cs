using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TMSWebTest.Models
{
    [Table("CustomerAndVendor")]
    public class CustomerAndVendor
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public int AccountId { get; set; }
        [Required]
        public bool IsCustomer { get; set; }
        
        public string VAT_NIP  { get; set; }
        public string Mobile { get; set; }

        public string Address { get; set; }

        public string Website { get; set; }

        public string Email { get; set; }

        public string Branch { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
        public string Notes { get; set; }
        public decimal MaxCredit { get; set; }

    }
}