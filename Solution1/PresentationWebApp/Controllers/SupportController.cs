﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PresentationWebApp.Controllers
{
    public class SupportController : Controller
    {
        [HttpGet]
        public IActionResult Contact()//This will be used to load the page
        {

            return View();
        }

        [HttpPost]
        public IActionResult Contact(string email, string query) //This will be used to handle the form subbmission
        {
            //... inform the responsible staff
            //Inform the user 

            if (string.IsNullOrEmpty(query))
            {
                TempData["warning"] = "Type in some question";
            }
            else
            {
                TempData["feedback"] = "Thank you for getting in touch with us. We will answer back asap";
            }
            return View();
        }
    }
}
