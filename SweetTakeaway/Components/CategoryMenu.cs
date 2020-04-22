using Microsoft.AspNetCore.Mvc;
using SweetTakeaway.Models;
using System.Collections.Generic;
using System.Linq;

namespace SweetTakeaway.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            IEnumerable<Category> categories = _categoryRepository.GetAllCategories.OrderBy(c => c.CategoryName);

            return View(categories);
        }
    }
}