using BlogProject_BusinessLayer.Concrete;
using BlogProject_BusinessLayer.ValidationRules;
using BlogProject_DataAccessLayer.EntityFramework;
using BlogProject_EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_UI.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogValidator bv = new BlogValidator();
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values = bm.GetListWithRelationship();
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {

            ViewBag.i = id;
            var values = bm.GetListAllById(id);
            return View(values);
        }

        public IActionResult BlogListByWriter(int id)
        {
            var values = bm.GetListWithCategoryByWriter(1);
            return View(values);
        }

        public IActionResult BlogAdd()
        {

            List<SelectListItem> categoryValues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.Id.ToString()
                                                   }).ToList();
            ViewBag.categoryValues = categoryValues;
            return View();
        }

        [HttpPost]

        public IActionResult BlogAdd(Blog blog)
        {
            List<SelectListItem> categoryValues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.Id.ToString()
                                                   }).ToList();
            ViewBag.categoryValues = categoryValues;
            ValidationResult result = bv.Validate(blog);
            if (result.IsValid)
            {
                blog.BlogStatus = true;
                blog.BlogCreateDate = DateTime.Now;
                blog.WriterId = 1;
                bm.Add(blog);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteBlog(int id)
        {
            var blogValue = bm.GetById(id);
            bm.Delete(blogValue);
            return RedirectToAction("BlogListByWriter", "Blog");
        }
        public IActionResult EditBlog(int id)
        {
            var blogValue = bm.GetById(id);

            List<SelectListItem> categoryValues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.Id.ToString()
                                                   }).ToList();
            ViewBag.categoryValues = categoryValues;

            return View(blogValue);
        }
        [HttpPost]
        public IActionResult EditBlog(Blog blog)
        {
            List<SelectListItem> categoryValues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.Id.ToString()
                                                   }).ToList();
            ViewBag.categoryValues = categoryValues;

            blog.WriterId = 1;
            blog.BlogCreateDate = DateTime.Now;
            blog.BlogStatus = true;
            bm.Update(blog);
            return RedirectToAction("BlogListByWriter", "Blog");
        }
    }
}

//public async Task<IActionResult> BlogAdd(Blog blog, IFormFile BlogImage)
//{
//    ValidationResult result = bv.Validate(blog);
//    ModelState.Remove("BlogImage");
//    ModelState.Remove("BlogThumbnailImage");
//    if (result.IsValid)
//    {
//        blog.BlogStatus = true;
//        blog.BlogCreateDate = DateTime.Now;
//        blog.WriterId = 1;
//        if (BlogImage != null)
//        {
//            blog.BlogImage = BlogImage.FileName;
//            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\CoreBlogTema\\images", BlogImage.FileName);
//            using (var stream = new FileStream(path, FileMode.Create))
//            {
//                await BlogImage.CopyToAsync(stream);
//            }
//        }
//        bm.Add(blog);
//        return RedirectToAction("BlogListByWriter", "Blog");
//    }
//    else
//    {
//        foreach (var item in result.Errors)
//        {
//            ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
//        }
//    }
//    return View();
//}