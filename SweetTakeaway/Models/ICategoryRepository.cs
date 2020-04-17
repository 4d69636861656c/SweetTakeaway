using System.Collections.Generic;

namespace SweetTakeaway.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get; }
    }
}