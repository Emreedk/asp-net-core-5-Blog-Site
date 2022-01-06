using BlogProject_BusinessLayer.Concrete;
using BlogProject_DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_UI.ViewComponents.Blog
{
    public class WritersLatestPosts:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public  IViewComponentResult Invoke()
        {
            
            var values = bm.GetBlogListByWriter(1);
            return View(values);
        }
    }
}
