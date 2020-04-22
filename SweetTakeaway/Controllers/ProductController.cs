using Microsoft.AspNetCore.Mvc;
using SweetTakeaway.Models;
using SweetTakeaway.ViewModels;
using System.Collections.Generic;
using System.Linq;

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

        public ViewResult List(string category)
        {
            //ViewBag.CurrentCategory = "Bestsellers";
            //return View(_productRepository.GetAllProducts);

            //ProductListViewModel productListViewModel = new ProductListViewModel();
            //productListViewModel.Products = _productRepository.GetAllProducts;
            //productListViewModel.CurrentCategory = "Bestsellers";

            //return View(productListViewModel);

            IEnumerable<Product> products;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                products = _productRepository.GetAllProducts.OrderBy(p => p.ProductId);
                currentCategory = "All products";
            }
            else
            {
                products = _productRepository.GetAllProducts.Where(p => p.Category.CategoryName == category);

                currentCategory = _categoryRepository.GetAllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new ProductListViewModel()
            { 
                Products = products,
                CurrentCategory = currentCategory
            });
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