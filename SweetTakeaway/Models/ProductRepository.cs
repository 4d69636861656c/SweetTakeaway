using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace SweetTakeaway.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;

        public IEnumerable<Product> GetAllProducts
        {
            get
            {
                return _appDbContext.Products.Include(p => p.Category);
            }
        }

        public IEnumerable<Product> GetProductsOnSale
        {
            get
            {
                return _appDbContext.Products.Include(p => p.Category).Where(p => p.IsOnSale);
            }
        }

        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Product GetProductById(int productId)
        {
            return _appDbContext.Products.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}