using ShoppingCart.application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.application.Interfaces
{
    public interface ICategoryService
    {
        IQueryable<CategoryViewModels> GetCategories();

    }
}
