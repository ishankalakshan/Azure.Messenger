using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Azure.Messenger.Models;

namespace Azure.Messenger.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]  
        public ActionResult Index(MessageViewModel Message)
        {
            return View();
        }

    }
}