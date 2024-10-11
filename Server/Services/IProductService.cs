using BlazorTestApp.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorTestApp.Server.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductByIdAsync(Guid id);
        Task<Product> CreateProductAsync(Product product);
        Task<bool> UpdateProductAsync(Product product);
        Task<bool> DeleteProductAsync(Guid id);
    }
}
