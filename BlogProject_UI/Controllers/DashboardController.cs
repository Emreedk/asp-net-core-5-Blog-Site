using BlogProject_BusinessLayer.Concrete;
using BlogProject_DataAccessLayer.Concrete;
using BlogProject_DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject_UI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            var values = cm.GetListWithRelationship();
            return View(values);
        }
    }
}
