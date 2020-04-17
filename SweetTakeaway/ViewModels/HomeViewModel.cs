using SweetTakeaway.Models;
using System.Collections.Generic;

namespace SweetTakeaway.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> ProductOnSale { get; set; }
    }
}