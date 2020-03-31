using InvaxTechnology.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvaxTechnology.Controllers
{
    public class InvaxController : Controller
    {
        // Make action ("methods" that lives in a controller)
        // methods in controllers are called "actions"

        // action Index is following the route pattern -> see Startup.cs
        [HttpGet]
        public string Index()
        {
            return "This is the home page.";
        }

        // This route is /Invax/Product/?productId=number
        public string Product(int productId)
        {
            return $"Welcome to the product page. This is product No.{productId}.";
        }

        public IActionResult AboutUs()
        {
            // View() is a reserved method call that ties directly into the generation of the views
            // View needs a return type called IActionResult
            // In Views folder, there needs to be a folder that has the same name as this controller (in this case Invax)
            // Inside the folder, a cshtml file needs to have the same name as this action -> AboutUs
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
