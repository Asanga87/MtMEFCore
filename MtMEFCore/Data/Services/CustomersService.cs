using Microsoft.EntityFrameworkCore;
using MtMEFCore.Data.ViewModels;
using MtMEFCore.Models;

namespace MtMEFCore.Data.Services
{
    public class CustomersService : ICustomersService
    {
        private readonly AppDbContext _context;
        public CustomersService(AppDbContext context)
        {
            _context = context;
        }

        public  async Task Add(NewCustomerVM customer)
        {
            var newCustomer = new Customer()
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Address = customer.Address,
                Phonenumber = customer.Phonenumber

            };
           await _context.Customers.AddAsync(newCustomer);
            await _context.SaveChangesAsync();

            foreach(var ShopId in customer.ShopIds)
            {
                var newCustomerShop = new Customer_Shop()
                {
                    CustomerID = newCustomer.ID,
                    ShopID = ShopId


                };
             await  _context.Customer_Shops.AddAsync(newCustomerShop);

            }
            await _context.SaveChangesAsync();
        }

        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

     
        public async Task<IEnumerable<Customer>> GetAll()
        {
            var data = await _context.Customers.ToListAsync();
            return data;
        }

        public Task<Customer> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<NewCustomerDropDownVM> GetNewCustomerDropDownValues()
        {
            var response = new NewCustomerDropDownVM();
            response.Shops = await _context.Shops.OrderBy(n=>n.Name).ToListAsync();
            return response;
        }

        public Task<Customer> Update(int Id, Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
