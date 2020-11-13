using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.application.Interfaces;

namespace PresentationWebApp.Controllers
{
    public class ProductsController : Controller
    {
        private IProductService _productsService;
          public ProductsController(IProductService productsServices)
            {
            _productsService = productsServices;
            }

        public IActionResult Index()
        {
            var list = _productsService.GetProducts();
            return View(list);
        }                
    }
}
