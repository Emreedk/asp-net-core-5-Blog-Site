using BlogProject_BusinessLayer.Concrete;
using BlogProject_BusinessLayer.ValidationRules;
using BlogProject_DataAccessLayer.EntityFramework;
using BlogProject_EntityLayer.Concrete;
using BlogProject_UI.Models;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_UI.Controllers
{

    public class RegisterController : Controller
    {
        WriterValidator wv = new WriterValidator();
        WriterManager wm = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {

            return View(new RegisterModel());
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterModel model,IFormFile image)
        {
            bool user = wm.UsernameMatchs(model.Username, model.Email);
            ModelState.Remove("WriterImage");
            if (ModelState.IsValid && user == false)
            {
                if (image != null)
                {
                    model.WriterImage = image.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\CoreBlogTema\\images", image.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await image.CopyToAsync(stream);
                    }
                }
                var entity = new Writer()
                {
                    WriterName = model.Name,
                    WriterSurname = model.Surname,
                    WriterAbout = model.About,
                    WriterImage=model.WriterImage,
                    WriterMail= model.Email,
                    WriterPassword=model.Password,
                    WriterStatus=true,
                    WriterUserName=model.Username
                };
                wm.Add(entity);
                return RedirectToAction("Index", "Login");
            }
            else
            {
                if (user)
                {
                    ModelState.AddModelError("AlreadyUsername", "Kullanıcı adı kayıtlı. Başka bir kullanıcı adı giriniz");
                    if (model.Email != null)
                    {
                        ModelState.AddModelError("AlreadyMail", "Mail adresi kayıtlı. Geçerli bir mail adresi giriniz.");
                    }

                }
            }
                return View(model);

        }

    }
}
