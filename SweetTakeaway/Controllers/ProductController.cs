using Microsoft.AspNetCore.Mvc;
using SweetTakeaway.Models;
using SweetTakeaway.ViewModels;

namespace SweetTakeaway.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            this._productRepository = productRepository;
            this._categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            //ViewBag.CurrentCategory = "Bestsellers";
            //return View(_productRepository.GetAllProducts);

            ProductListViewModel productListViewModel = new ProductListViewModel();
            productListViewModel.Products = _productRepository.GetAllProducts;
            productListViewModel.CurrentCategory = "Bestsellers";

            return View(productListViewModel);
        }

        public IActionResult Details(int productId)
        {
            Product product = _productRepository.GetProductById(productId);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}