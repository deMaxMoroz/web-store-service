using LearnWebAPI.DTOs;
using LearnWebAPI.Models;
using System.Runtime.CompilerServices;
namespace LearnWebAPI.Mappers
{
    public static class ProductMappers
    {
        public static ProductDto ToProductDto(this Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                ProductCount = product.ProductCount,
               
            };
        }

        public static Product ToProductFromCreateDto(this CreateProductDto createProductDto)
        {
            return new Product
            {
                Name = createProductDto.Name,
                Description = createProductDto.Description,
                Price = createProductDto.Price,
                ProductCount = createProductDto.ProductCount,
            };
        }

    }
}
