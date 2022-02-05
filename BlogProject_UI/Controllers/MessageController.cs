using BlogProject_BusinessLayer.Concrete;
using BlogProject_DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_UI.Controllers
{
    public class MessageController : Controller
    {
        MessageManager mm = new MessageManager(new EfMessageRepository());
        public IActionResult InBox()
        {
            int id = 2;
            var values = mm.GetInboxListByWriter(id);
            return View(values);
        }

        public IActionResult MessageDetails(int id)
        {
            var values = mm.GetById(id);
            return View(values);
        }
    }
}
