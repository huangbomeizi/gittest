using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManagerSystem.Models;

namespace ManagerSystem.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private BookContext dbBook = new BookContext(); 
        public ActionResult Index()
        {
            var books = from b in dbBook.Books 
                        where b.Author.Equals("Tom") 
                        select b;
            return View(books.ToList());
        }

        public ActionResult Welcome() {
            return View();
        }

    }
}
