using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.application.Interfaces;
using ShoppingCart.application.ViewModels;

namespace PresentationWebApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productsService;
        private readonly ICategoryService _categoryService;
         public ProductsController(IProductService productsServices , ICategoryService categoryService)
            {
            _productsService = productsServices;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var list = _productsService.GetProducts();
            return View(list);
        }    
        public IActionResult Details(Guid id)
        {
            var p =_productsService.GetProduct(id);
            return View(p);
        }
        [HttpGet]
        public IActionResult Create()
        {
            //Fetch a list of categories 
            var listofCategories = _categoryService.GetCategories();
            ViewBag.Categories = listofCategories;
            //We pass the categorieues to the page 
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductViewModels data)
        {
            try
            {
                _productsService.AddProduct(data);

                ViewData["feedback"] = "Product was added sucessfully";
            }
            catch(Exception ex)
            {
                //log error
                ViewData["warning"] = "Product was not added";
            }
            var listofCategories = _categoryService.GetCategories();
            ViewBag.Categories = listofCategories;
            return View(data);
        }
    
    }
}
