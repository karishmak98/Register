using Microsoft.AspNetCore.Mvc;

namespace RegisterForm.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
