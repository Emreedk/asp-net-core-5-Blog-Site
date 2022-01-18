using BlogProject_BusinessLayer.Concrete;
using BlogProject_BusinessLayer.ValidationRules;
using BlogProject_DataAccessLayer.EntityFramework;
using BlogProject_EntityLayer.Concrete;
using BlogProject_UI.Models;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
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
            return View(new BlogModel());
        }

        [HttpPost]

        public async Task<IActionResult> BlogAdd(BlogModel model, IFormFile image)
        {
            List<SelectListItem> categoryValues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.Id.ToString()
                                                   }).ToList();
            ViewBag.categoryValues = categoryValues;
            ModelState.Remove("BlogImage");
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    model.BlogImage = image.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\CoreBlogTema\\images", image.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await image.CopyToAsync(stream);
                    }
                }
                //if (thumbnail != null)
                //{
                //    model.BlogThumbnailImage = thumbnail.FileName;
                //    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\CoreBlogTema\\images", thumbnail.FileName);
                //    using (var stream = new FileStream(path, FileMode.Create))
                //    {
                //        await thumbnail.CopyToAsync(stream);
                //    }
                //}
                var entity = new Blog()
                {
                    BlogTitle = model.BlogTitle,
                    CategoryId = model.CategoryId,
                    BlogContent = model.BlogContent,
                    BlogCreateDate = DateTime.Now,
                    BlogStatus = true,
                    BlogImage = model.BlogImage,
                    //BlogThumbnailImage = model.BlogThumbnailImage,
                    WriterId = 1

                };

                bm.Add(entity);
                return RedirectToAction("Index", "Blog");
            }

            return View();
        }

        public IActionResult DeleteBlog(int id)
        {
            var blogValue = bm.GetById(id);
            bm.Delete(blogValue);
            return RedirectToAction("BlogListByWriter", "Blog");
        }
        public IActionResult EditBlog(int? id)
        {
            var blogValue = bm.GetById((int)id);

            List<SelectListItem> categoryValues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.Id.ToString()
                                                   }).ToList();
            ViewBag.categoryValues = categoryValues;

            var model = new BlogModel()
            {
                Id = blogValue.Id,
                BlogTitle = blogValue.BlogTitle,
                BlogContent = blogValue.BlogContent,
                CategoryId = blogValue.CategoryId,
                BlogImage = blogValue.BlogImage,
                //BlogThumbnailImage = blogValue.BlogThumbnailImage

            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditBlog(BlogModel model, IFormFile image)
        {
            List<SelectListItem> categoryValues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.Id.ToString()
                                                   }).ToList();
            ViewBag.categoryValues = categoryValues;

            ModelState.Remove("image");
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    model.BlogImage = image.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\CoreBlogTema\\images", image.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await image.CopyToAsync(stream);
                    }
                }
                //if (thumbnail != null)
                //{
                //    model.BlogThumbnailImage = thumbnail.FileName;
                //    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\CoreBlogTema\\images", thumbnail.FileName);
                //    using (var stream = new FileStream(path, FileMode.Create))
                //    {
                //        await thumbnail.CopyToAsync(stream);
                //    }
                //}

                var entity = bm.GetById(model.Id);
                if (entity == null)
                {
                    return NotFound();
                }
                entity.BlogTitle = model.BlogTitle;
                entity.BlogContent = model.BlogContent;
                entity.BlogImage = model.BlogImage;
                //entity.BlogThumbnailImage = model.BlogThumbnailImage;
                entity.BlogStatus = true;
                entity.CategoryId = model.CategoryId;
                entity.BlogCreateDate = DateTime.Now;
                entity.WriterId = 1;

                bm.Update(entity);

                return RedirectToAction("BlogListByWriter", "Blog");
            }

            return View(model);
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