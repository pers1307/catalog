using System.Collections.Generic;
using Catalog.Entities;

namespace Catalog.Areas.Catalog.ViewModels
{
    public class HomeViewModel
    {
        public HomeViewModel(IReadOnlyList<Product> products)
        {
            Products = products;
        }
        
        private IReadOnlyList<Product> Products { get; }
    }
}