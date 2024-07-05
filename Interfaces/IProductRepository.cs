using LearnWebAPI.Models;

namespace LearnWebAPI.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();
    }
}
