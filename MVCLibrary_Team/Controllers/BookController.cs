using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCLibrary_Team.Data;
using MVCLibrary_Team.Models;

namespace MVCLibrary_Team.Controllers
{
    public class BookController : Controller
    {
        private readonly IRepository<Book> bookRepository;
        private readonly IRepository<Category> categoryRepository;
        public BookController(IRepository<Book> baseDataModel, IRepository<Category> categoryrepository)
        {
            bookRepository = baseDataModel as BookRepository;
            this.categoryRepository = categoryrepository;
        }
        public IActionResult Index()
        {
            return View(bookRepository.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["Items"] = new SelectList(categoryRepository.GetAll(), "Id", "Title");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            bookRepository.Add(book);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            bookRepository.Delete(bookRepository.GetById(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var model = bookRepository.GetById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Update(Book book, int id)
        {
            bookRepository.Update(book, id);
            return RedirectToAction("Index");
        }
    }
}
