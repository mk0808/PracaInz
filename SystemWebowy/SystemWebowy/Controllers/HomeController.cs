using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SystemWebowy.DataAccessLayer;
using SystemWebowy.Models;

namespace SystemWebowy.Controllers
{
    public class HomeController : Controller
    {
        private CukierniaDBContext db = new CukierniaDBContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Kategorie.ToList());
        }
        [ChildActionOnly]
        public ActionResult KategorieMenu()
        {
            var kategorie = db.Kategorie.ToList();
            return PartialView("_KategorieMenu", kategorie);
        }
    }
}