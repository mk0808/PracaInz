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
            //Kategoria kategoria = new Kategoria { NazwaKategorii = "Torty" };
            //db.Kategorie.Add(kategoria);
            //db.SaveChanges();
            return View();
        }
    }
}