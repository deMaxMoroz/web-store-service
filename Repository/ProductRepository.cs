using LearnWebAPI.DataContext;
using LearnWebAPI.Interfaces;
using LearnWebAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace LearnWebAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        
        public ProductRepository(AppDbContext context) {
            _context = context;
            
        }
        public Task<List<Product>> GetAllAsync()
        {
            return _context.Products.ToListAsync();
        }
    }
}
