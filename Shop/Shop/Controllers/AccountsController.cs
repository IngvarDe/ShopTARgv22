using Microsoft.AspNetCore.Mvc;

namespace Shop.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
