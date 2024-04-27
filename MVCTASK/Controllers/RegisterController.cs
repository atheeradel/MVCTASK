using Microsoft.AspNetCore.Mvc;

namespace MVCTASK.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

    }
}
