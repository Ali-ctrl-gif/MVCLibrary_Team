using Microsoft.AspNetCore.Mvc;
using MVCLibrary_Team.Data;
using MVCLibrary_Team.Models;

public class BorrowController : Controller
{
    public IRepository<Borrow> BorrowRepository { get; set; }

    public BorrowController(IRepository<Borrow> repository)
    {
        BorrowRepository = repository;
    }

    public IActionResult Index()
    {
        var borrows = BorrowRepository.GetAll();
        return View(borrows);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Borrow model)
    {
        if (ModelState.IsValid)
        {
            BorrowRepository.Add(model);
            return RedirectToAction("Index");
        }
        return View(model);
    }
}
