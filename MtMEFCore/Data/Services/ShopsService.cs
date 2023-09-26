using Microsoft.EntityFrameworkCore;
using MtMEFCore.Data.ViewModels;
using MtMEFCore.Models;

namespace MtMEFCore.Data.Services
{
    public class ShopsService :  IShopService
    {
        private readonly AppDbContext _context;

        public ShopsService(AppDbContext context) 
        {
            _context = context;
        
        }

        public async Task Add(Shop shop)
        {
           await _context.Shops.AddAsync(shop);   
           await _context.SaveChangesAsync();
        }

        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Shop>> GetAll()
        {
            var data= await _context.Shops.ToListAsync();
            return data;
        }

        public Task<Shop> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Shop> Update(int Id, Shop shop)
        {
            throw new NotImplementedException();
        }
    }
}
