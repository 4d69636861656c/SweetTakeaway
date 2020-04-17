using Microsoft.AspNetCore.Mvc;
using SweetTakeaway.Models;
using SweetTakeaway.ViewModels;

namespace SweetTakeaway.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                ProductOnSale = _productRepository.GetProductsOnSale
            };

            return View(homeViewModel);
        }
    }
}