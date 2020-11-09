
using Shoppingcart.domain.Interfaces;
using ShoppingCart.application.Interfaces;
using ShoppingCart.application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.application.Services
{
    public class ProductsService : IProductService
    {
        public IProductsRepository _productsRep;
        public ProductsService(IProductsRepository productsRepository)
        {
            _productsRep = productsRepository;
        }
        public IQueryable<ProductViewModels> GetProducts()
        {
            //To be implemented unsing autoampper
            var list = from p in _productsRep.GetProducts()
                       select new ProductViewModels()
                       {
                           id = p.id,
                           Desc = p.Desc,
                           Name = p.Name,
                           Price = p.Price,
                           category = new CategoryProductModels() { id = p.category.id, Name = p.category.Name }
                       };
            return list;
        }

        public IQueryable<ProductViewModels> GetProducts(int category)
        {

            var list = from p in _productsRep.GetProducts().Where(x => x.category.id == category)
            select new ProductViewModels()
                       {
                           id = p.id,
                           Desc = p.Desc,
                           Name = p.Name,
                           Price = p.Price,
                           category = new CategoryProductModels() { id = p.category.id, Name = p.category.Name }
                       };
            return list;
        }
    }
}
