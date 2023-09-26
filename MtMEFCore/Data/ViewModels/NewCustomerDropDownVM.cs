using MtMEFCore.Models;

namespace MtMEFCore.Data.ViewModels
{
    public class NewCustomerDropDownVM
    {

        public NewCustomerDropDownVM()
        {
            Shops=new List<Shop>();
        }
        public List<Shop> Shops { get; set; }
    }
}
