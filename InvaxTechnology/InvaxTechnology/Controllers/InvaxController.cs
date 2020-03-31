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
        public string Index()
        {
            return "This is the home page.";
        }

    }
}
