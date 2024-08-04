using Microsoft.AspNetCore.Mvc;

namespace RegisterForm.Controllers
{
    public class UserController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
