using BlogProject_BusinessLayer.Concrete;
using BlogProject_DataAccessLayer.EntityFramework;
using BlogProject_EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_UI.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager nm = new NewsLetterManager(new EfNewsLetterRepository());
        public PartialViewResult SubscribeMail()
        {            
            return PartialView();
        }
        [HttpPost]
        public void SubscribeMail(NewsLetter newsLetter)
        {
            newsLetter.MailStatus = true;
            nm.AddNewsLetter(newsLetter);           
        }
    }
}
