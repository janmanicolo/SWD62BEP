using Shoppingcart.domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shoppingcart.domain.Interfaces
{
    public interface ICategoryRepository
    {
        IQueryable<Category> GetCategories();
    }
}
