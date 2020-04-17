using System.Collections.Generic;

namespace SweetTakeaway.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public IEnumerable<Category> GetAllCategories
        {
            get
            {
                return _appDbContext.Categories;
            }
        }

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}