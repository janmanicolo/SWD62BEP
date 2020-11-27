using ShoppincCart.data.Context;
using Shoppingcart.domain.Interfaces;
using Shoppingcart.domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppincCart.data.Repositories
{
    public class CategoriesRepository : ICategoryRepository
    {
        ShoppingCartDbContext _context;
        public CategoriesRepository(ShoppingCartDbContext context)
        {
            _context = context;
        }

        public IQueryable<Category> GetCategories()
        {
            return _context.Categories;
        }
    }
}
