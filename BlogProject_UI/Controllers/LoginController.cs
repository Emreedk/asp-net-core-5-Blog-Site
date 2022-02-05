using BlogProject_DataAccessLayer.Concrete;
using BlogProject_EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlogProject_UI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Writer writer)
        {

            Context c = new Context();
            var dataValue = c.Writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail && x.WriterPassword == writer.WriterPassword);
             
            if (dataValue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, writer.WriterMail),
                    new Claim(ClaimTypes.Name, writer.Id.ToString())
                };
                var userIdentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                return View();
            }
        }
    }
}


