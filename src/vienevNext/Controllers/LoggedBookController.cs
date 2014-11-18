using Microsoft.AspNet.Mvc;
using WebApplication1.Repository;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class LoggedBookController : Controller
    {
        private IBookRepository _repository;
        private IMessageLogger _messageLogger;

        public LoggedBookController(IBookRepository repository, IMessageLogger messageLogger)
        {
            _repository = repository;
            _messageLogger = messageLogger;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            _messageLogger.Log("Getting all items");
            return View(_repository.GetAll());
        }
    }
}
