using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActaulizarSeven.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            int a = 1;
            string b;
            string c;
            
            b = a.ToString();
            c = b;
            b = a.ToString();
            b = c;
            b = c;
            b = a.ToString();
            return View();
        }
    }
}