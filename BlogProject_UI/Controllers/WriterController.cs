using BlogProject_BusinessLayer.Concrete;
using BlogProject_BusinessLayer.ValidationRules;
using BlogProject_DataAccessLayer.Concrete;
using BlogProject_DataAccessLayer.EntityFramework;
using BlogProject_EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlogProject_UI.Controllers
{
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            string mail = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Email).Value.ToString();

            var id = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value;
            ViewBag.v = mail;
            ViewBag.v2 = wm.GetByAuth(mail).WriterName;

            //var userMail = User.Identity.Name;
            //ViewBag.v = userMail;
            //Context c = new Context();
            //var userName = c.Writers.Where(z => z.WriterMail == userMail).Select(y => y.WriterUserName).FirstOrDefault();
            //ViewBag.v2 = userName;
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }

        public IActionResult WriterEditProfile()
        {
            string mail = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Email).Value.ToString();
            
            var writerValues = wm.GetByAuth(mail);
            return View(writerValues);
        }

        [HttpPost]
        public IActionResult WriterEditProfile(Writer writer)
        {
            WriterValidator wv = new WriterValidator();
            ValidationResult result = wv.Validate(writer);
            if (result.IsValid)
            {
                writer.WriterStatus = true;
                wm.Update(writer);
                return RedirectToAction("Index", "Dashboard");
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
