using System.Collections.Generic;

namespace SweetTakeaway.Models
{
    public interface IProductRepository
    {
        Product GetProductById(int productId);
        IEnumerable<Product> GetAllProducts { get; }
        IEnumerable<Product> GetProductsOnSale { get; }
    }
}