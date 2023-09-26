namespace MtMEFCore.Models
{
    public class Customer_Shop
    {
        public int CustomerID { get; set; }

        public Customer Customer { get; set; }  

        //-----------------------------------------

        public int ShopID { get; set; }

        public Shop Shop { get; set; }  
    }
}
