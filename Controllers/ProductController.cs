using LearnWebAPI.DataContext;
using LearnWebAPI.Mappers;
using LearnWebAPI.Models;
using LearnWebAPI.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LearnWebAPI.Interfaces;

namespace LearnWebAPI.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        private readonly IProductRepository _prodRepo;
        public ProductController(AppDbContext dbContext, IProductRepository prodRepo)
        {
            _dbContext = dbContext;
            _prodRepo = prodRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Product> prodModel = await _prodRepo.GetAllAsync();
            List<ProductDto> prodDto = prodModel.Select(c => c.ToProductDto()).ToList();
            return Ok(prodDto);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            Product? product = await _dbContext.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product.ToProductDto());

        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateProductDto productDto)
        {
            Product product = productDto.ToProductFromCreateDto();
            await _dbContext.Products.AddAsync(product);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }


        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateProductDto productDto)
        {
            Product? updProd = await _dbContext.Products.FirstOrDefaultAsync(x=>x.Id == id);
            if (updProd == null)
            {
                return NotFound();
            }
            updProd.Name = productDto.Name;
            updProd.Description = productDto.Description;
            updProd.Price = productDto.Price;
            updProd.ProductCount = productDto.ProductCount;

            await _dbContext.SaveChangesAsync();
            return Ok(updProd.ToProductDto());
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            Product? delProd = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (delProd == null)
            {
                return NotFound();
            }
            _dbContext.Products.Remove(delProd);
            await _dbContext.SaveChangesAsync();
            return NoContent();
        }
    }

}
