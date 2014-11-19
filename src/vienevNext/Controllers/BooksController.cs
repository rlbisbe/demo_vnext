using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using WebApplication1.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class BooksController : Controller
    {
        static readonly List<Book> _books = new List<Book>()
        {
            new Book {Title = "ASP.net en Mac", Author = "Eduard Tomás" , Year = 2014},
            new Book {Title = "Agile ALM y Motos", Author = "Juan Carlos Quijano", Year = 2010 },
            new Book {Title = "Conectando Windows Phone con cosas", Author = "Roberto Luis Bisbé", Year = 2009 }
        };

        [HttpGet("[controller].json")]
        public IActionResult Get()
        {
            return new ObjectResult(_books);
        }


        [HttpGet("[controller]")]
        public IActionResult Index()
        {
            return View(_books);
        }

        [HttpGet("[controller]/{id:int}.json")]
        public IActionResult GetById(int id)
        {
            return new ObjectResult(_books[id]);
        }
    }
}
