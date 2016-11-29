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
        public static Library library = new Library("The Library of Alexandria","Boise, ID");

        public IActionResult Index()
        {
      
            return View(library);
        }
        public IActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBook(string title, string author, string description)
        {
            if(title == null || author == null)
            {
                return RedirectToAction("AddBook");
            }
            library.AddBook(new Book(title, author, description));
            return RedirectToAction("Index");
        }
        public IActionResult GetBook()
        {
            return View();
        }
        
        public IActionResult GetBook(string title, string author, string description)
        {
            if(title == null || author == null)
            {
                return RedirectToAction("GetBook");
            }
            library.GetBook(new Book(title, author, description));
            return RedirectToAction("Index");
        }
    }
}