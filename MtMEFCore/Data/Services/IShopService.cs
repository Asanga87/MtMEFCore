using MtMEFCore.Models;

namespace MtMEFCore.Data.Services
{
    public interface IShopService
    {
        Task<IEnumerable<Shop>> GetAll();

        Task<Shop> GetById(int id);

        Task Add(Shop shop);

        Task<Shop> Update(int Id, Shop shop);

        Task Delete(int Id);

       
    }
}
