using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc_library.Models;

namespace mvc_library.Controllers
{
    public class LibraryController : Controller
    {
        public Library library = new Library("The Library of Alexandria","Boise, ID");

        public IActionResult Index()
        {
            return View(library);
        }
    }
}