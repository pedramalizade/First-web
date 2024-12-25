using Microsoft.AspNetCore.Mvc;

namespace ShowProducts.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult ChooseAction()
        {
            return View();
        }
    }
}
