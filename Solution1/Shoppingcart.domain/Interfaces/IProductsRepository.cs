using Shoppingcart.domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shoppingcart.domain.Interfaces
{
    public interface IProductsRepository
    {
        IQueryable<Product> GetProducts();

        Product GetProduct(Guid id);

        void DeleteProduct(Product p);
        Guid AddProduct(Product p);

    }
}
