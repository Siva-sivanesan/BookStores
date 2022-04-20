using BookStores.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStores.Controllers
{
    public class BooksController : Controller
    {
        public int ID { get; private set; }
        public string Title { get; private set; }
        public string Genre { get; private set; }
        public int Price { get; private set; }
        public DateTime PublishDate { get; private set; }
        public List<string> Authors { get; private set; }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            Book book = new Book()
            {
                ID = 1,
                Title = "Learning ASP.NET Core 2.0",
                Genre = "Programming and software development",
                Price = 45,
                PublishDate = new System.DateTime(2022, 04, 06),
                Authors = new List<string> { "William Shakespeare, Oscar Wilde" }
            };
            return View(book);
        }
    }
}
