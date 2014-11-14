using Microsoft.AspNet.Mvc;
using WebApplication1.Repository;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class BookRepositoryController : Controller
    {
        private IBookRepository _repository;

        public BookRepositoryController(IBookRepository repository)
        {
            _repository = repository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_repository.GetAll());
        }
    }
}
