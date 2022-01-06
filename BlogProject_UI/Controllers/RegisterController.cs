using BlogProject_BusinessLayer.Concrete;
using BlogProject_BusinessLayer.ValidationRules;
using BlogProject_DataAccessLayer.EntityFramework;
using BlogProject_EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_UI.Controllers
{

    public class RegisterController : Controller
    {
        WriterValidation wv = new WriterValidation();
        WriterManager wm = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            ValidationResult result = wv.Validate(writer);
            if (result.IsValid)
            {
                writer.WriterStatus = true;
                wm.WriterAdd(writer);
                return RedirectToAction("Index", "Blog");
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

    }
}
