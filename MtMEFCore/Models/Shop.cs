using System.ComponentModel.DataAnnotations;

namespace MtMEFCore.Models
{
    public class Shop
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string address { get; set; }

        public List<Customer_Shop>? customer_Shops { get; set; }

    }
}
