using Microsoft.AspNetCore.Mvc;
using MVCLibrary_Team.Data;
using MVCLibrary_Team.Models;

namespace MVCLibrary_Team.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository repository;
        public BookController(IRepository<Book> baseDataModel)
        {
            repository = baseDataModel as BookRepository;
        }
        public IActionResult Index()
        {
            return View(repository.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            repository.Add(book);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            repository.Delete(repository.GetById(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var model = repository.GetById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Update(Book book, int id)
        {
            repository.Update(book, id);
            return RedirectToAction("Index");
        }
    }
}
