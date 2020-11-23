using Microsoft.EntityFrameworkCore;
using ShoppincCart.data.Context;
using Shoppingcart.domain.Interfaces;
using Shoppingcart.domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppincCart.data.Repositories
{
    public class ProductsRepositorycs : IProductsRepository
    {
        ShoppingCartDbContext _context;
        public ProductsRepositorycs(ShoppingCartDbContext context)
        {
            _context = context;
        }
        public Guid AddProduct(Product p)
        {
            _context.products.Add(p);
            _context.SaveChanges();
            return p.id;

        }

        public void DeleteProduct(Product p)
        {
            _context.products.Remove(p);
            _context.SaveChanges();
        }

        public Product GetProduct(Guid id)
        {
            //Single or default will retutnr one product or null
            return _context.products.SingleOrDefault(x => x.id == id);
        }

        public IQueryable<Product> GetProducts()
        {
            return _context.products;
        }
    }
}
