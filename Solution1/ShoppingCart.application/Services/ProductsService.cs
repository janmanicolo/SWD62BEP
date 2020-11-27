
using Shoppingcart.domain.Interfaces;
using Shoppingcart.domain.Models;
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

        public void AddProduct(ProductViewModels product)
        {
            Product newProduct = new Product()
            {
                Desc = product.Desc,
                Name = product.Name,
                Price = product.Price,
                CategoryID = product.category.id,
                ImageUrl = product.ImageUrl
            };

            _productsRep.AddProduct(newProduct);

        }

        public ProductViewModels GetProduct(Guid id)
        {
            var myProduct = _productsRep.GetProduct(id);
            ProductViewModels myModel = new ProductViewModels();
            myModel.Desc = myProduct.Desc;
            myModel.ImageUrl = myProduct.ImageUrl;
            myModel.Name = myProduct.Name;
            myModel.Price = myProduct.Price;
            myModel.id = myProduct.id;
            myModel.category = new CategoryViewModels {
                id = myProduct.category.id,
                Name = myProduct.category.Name
            };

            return myModel;
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
                           category = new CategoryViewModels() { id = p.category.id, Name = p.category.Name },
                           ImageUrl = p.ImageUrl
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
                           category = new CategoryViewModels() { id = p.category.id, Name = p.category.Name },
                           ImageUrl = p.ImageUrl
                       };
            return list;
        }
    }
}
