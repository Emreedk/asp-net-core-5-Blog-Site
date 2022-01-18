using BlogProject_BusinessLayer.Concrete;
using BlogProject_DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_UI.ViewComponents.Dashboard
{
    public class TotalBlogCountOnDashboard:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            BlogManager bm = new BlogManager(new EfBlogRepository());
            var values = bm.GetList();
            return View(values);
        }
    }
}
