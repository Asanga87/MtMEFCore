
using System.ComponentModel.DataAnnotations;

namespace MtMEFCore.Models
{
    public class NewCustomerVM
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Phone Number")]
        public string Phonenumber { get; set; }

        public List<int>? ShopIds { get; set; }
    }
}
