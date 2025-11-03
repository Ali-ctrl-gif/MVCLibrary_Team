using Microsoft.AspNetCore.Mvc;
using MVCLibrary_Team.Models;

namespace MVCLibrary_Team.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            bookRepository.Create(book);
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
