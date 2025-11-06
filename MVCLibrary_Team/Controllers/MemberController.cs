using Microsoft.AspNetCore.Mvc;
using MVCLibrary_Team.Data;
using MVCLibrary_Team.Models;

namespace MVCLibrary_Team.Controllers
{
    public class MemberController : Controller
    {
        private readonly MemberRepository _repository;
        private readonly BorrowRepository _borrowRepo;
        public MemberController(IRepository<Member> repository, IRepository<Borrow> borrowRepo)
        {
            _repository = repository as MemberRepository;
            _borrowRepo = borrowRepo as BorrowRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            if (!string.IsNullOrEmpty(Convert.ToString(HttpContext.Session.GetInt32("_userId"))))
                return RedirectToAction("Profile");
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(HttpContext.Session.GetInt32("_userId"))))
                return RedirectToAction("Profile");

            var user = _repository.GetAll().FirstOrDefault(x => x.Username == username && x.Password == password);
            if (user != null)
            {
                HttpContext.Session.SetInt32("_userId", user.Id);
                HttpContext.Session.SetInt32("_userType", (user.IsAdmin ? 1 : 0));
                HttpContext.Session.SetString("_userFullName", user.FullName);
                return RedirectToAction("Profile");
            }
            else
            {
                TempData["notificationLogin"] = "Username or Password is Wrong!";
                return View();
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }
        public IActionResult Profile()
        {
            if (string.IsNullOrEmpty(Convert.ToString(HttpContext.Session.GetInt32("_userId"))))
                return NotFound();
            var records = _borrowRepo.GetAll().Where(x => x.UserId == HttpContext.Session.GetInt32("_userId"));
            return View(records);
        }
    }
}
