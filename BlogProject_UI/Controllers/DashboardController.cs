using Microsoft.AspNetCore.Mvc;

namespace BlogProject_UI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
