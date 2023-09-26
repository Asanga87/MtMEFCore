using MtMEFCore.Data.ViewModels;
using MtMEFCore.Models;

namespace MtMEFCore.Data.Services
{
    public interface ICustomersService
    {
        Task<IEnumerable<Customer>> GetAll(); 

        Task<Customer> GetById(int id);

        Task Add(NewCustomerVM customer);

        Task<Customer> Update(int Id, Customer customer);

        Task Delete(int Id);

        Task<NewCustomerDropDownVM> GetNewCustomerDropDownValues();
    
    }
}
