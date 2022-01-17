using BlogProject_DataAccessLayer.Concrete;
using BlogProject_EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public IActionResult Index(Writer writer)
        {

            Context c = new Context();
            var dataValue = c.Writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail || x.WriterUserName == writer.WriterUserName && x.WriterPassword == writer.WriterPassword);
            if (dataValue != null)
            {
                if (writer.WriterMail != null)
                {
                    HttpContext.Session.SetString("username", writer.WriterMail);
                    //HttpContext.Session.SetInt32("userId", writer.Id);
                }
                if (writer.WriterUserName != null)
                {
                    HttpContext.Session.SetString("username", writer.WriterUserName);

                }

                return RedirectToAction("Index", "Blog");

            }
            else
            {
                return View();
            }
        }
    }
}


//Context c = new Context();
//var dataValue = c.Writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail /*|| x.WriterUserName == writer.WriterUserName*/ && x.WriterPassword == writer.WriterPassword);

//if (dataValue != null)
//{
//    var claims = new List<Claim>
//    {
//        new Claim(ClaimTypes.Name, writer.WriterMail)
//    };
//    var userIdentity = new ClaimsIdentity(claims, "a");
//    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
//    await HttpContext.SignInAsync(principal);
//    return RedirectToAction("Index", "Blog");
//}
//else
//{
//    return View();
//}