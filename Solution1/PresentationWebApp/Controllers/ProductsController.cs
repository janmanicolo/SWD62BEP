using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.application.Interfaces;
using ShoppingCart.application.ViewModels;

namespace PresentationWebApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productsService;
        private readonly ICategoryService _categoryService;

        private IWebHostEnvironment _env;
         public ProductsController(IProductService productsServices , ICategoryService categoryService,
             IWebHostEnvironment env)
            {
            _productsService = productsServices;
            _categoryService = categoryService;
            _env = env; 
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
        [Authorize (Roles = "Admin")]
        public IActionResult Create()
        {
            //Fetch a list of categories 
            var listofCategories = _categoryService.GetCategories();
            ViewBag.Categories = listofCategories;
            //We pass the categorieues to the page 
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(ProductViewModels data, IFormFile f)
        {
            try
            {
                if (f != null)
                {
                    if (f.Length > 0)
                    {
                        //D:\School\Ep\SWD62BEP\Solution1\PresentationWebApp\wwwroot\Images\
                        string newFileName = Guid.NewGuid() + System.IO.Path.GetExtension(f.FileName);
                        string newFileNameWithAbsolutePath = _env.WebRootPath+ @"\Images\" + newFileName;

                        using (var stream = System.IO.File.Create(newFileNameWithAbsolutePath))
                        {
                            f.CopyTo(stream);
                        }
                        data.ImageUrl = @"\Images\" + newFileName;
                    }
                }
                _productsService.AddProduct(data);

                TempData["feedback"] = "Product was added sucessfully";
            }
            catch(Exception ex)
            {
                //log error
                TempData["warning"] = "Product was not added";
            }
            var listofCategories = _categoryService.GetCategories();
            ViewBag.Categories = listofCategories;
            return View(data);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _productsService.DeleteProduct(id);
                TempData["feedback"] = "Product was deleted";
            }
            catch
            {
                TempData["warning"] = "product was not deleted";
            }
            return RedirectToAction("Index");
        }
    
    }
}
