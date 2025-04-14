using ProductMicroservice.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductMicroservice.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task<Product> CreateAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
    }
}
