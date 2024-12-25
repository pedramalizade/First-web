using Microsoft.AspNetCore.Mvc;
using ShowProducts.Models;
using ShowProducts.Models.Db;
using ShowProducts.Models.Interface.Service;
using ShowProducts.Models.Service;

namespace ShowProducts.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _service = new UserService();
        private readonly ProductDbContext _dbContext;
        public UserController()
        {
            _dbContext = new ProductDbContext();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                _service.Register(user);
                return RedirectToAction("Login");
            }
            return View(User);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {

            var user = _dbContext.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);
            if(user != null)
            {
                TempData["Message"] = "Login Successful";
                return RedirectToAction("Index");
            }
            TempData["Error"] = "Invalid username or password";
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
