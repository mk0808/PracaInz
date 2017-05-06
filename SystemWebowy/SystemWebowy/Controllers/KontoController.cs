using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SystemWebowy.Controllers
{
    public class KontoController : Controller
    {
        // GET: Konto
        public ActionResult Login()
        {
            return View();
        }
    }
}