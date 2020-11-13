using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.application.ViewModels
{
    public class ProductViewModels
    {

        public Guid id { get; set; }
        public string Name { get; set; }
        
        public double Price { get; set; }

        public string Desc { get; set; }

        
        public CategoryProductModels category { get; set; }

        public string ImageUrl { get; set; }
    }
}
