using Shoppingcart.domain.Interfaces;
using ShoppingCart.application.Interfaces;
using ShoppingCart.application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.application.Services
{
    public class CategoriesService : ICategoryService
    {
        public ICategoryRepository _categoriesRep;
        public CategoriesService(ICategoryRepository CategoriesRepository)
        {
            _categoriesRep = CategoriesRepository;
        }
        public IQueryable<CategoryViewModels> GetCategories()
        {
            var list = from c in _categoriesRep.GetCategories()
                       select new CategoryViewModels()
                       {
                           id = c.id,
                           Name = c.Name
                       };
            return list;
        }
    }
}
