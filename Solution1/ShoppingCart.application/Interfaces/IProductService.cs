using ShoppingCart.application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.application.Interfaces
{
    public interface IProductService
    {
        IQueryable<ProductViewModels> GetProducts();

        IQueryable<ProductViewModels> GetProducts(int category);

        ProductViewModels GetProduct(Guid id);
    }
}
