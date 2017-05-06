using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SystemWebowy.DataAccessLayer;
using SystemWebowy.Models;
using SystemWebowy.ViewModels;

namespace SystemWebowy.Controllers
{
    public class ProduktyController : Controller
    {
        //private static Logger logger = LogManager.GetCurrentClassLogger();
        private CukierniaDBContext db = new CukierniaDBContext();
        

        public ActionResult Index()
        {
            return View();
        }
        public ViewResult Lista(string nazwaKategorii)
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult ProduktyList()
        {
            var produkty = db.Produkty.ToList();
            return PartialView("_ProduktyList", produkty);
        }
        [ChildActionOnly]
        public ActionResult KategorieMenu()
        {
            var kategorie = db.Kategorie.ToList();
            return PartialView("_KategorieMenu", kategorie);
        }
        [ChildActionOnly]
        public ActionResult KategorieFiltr()
        {
            var kategorie = db.Kategorie.ToList();
            return PartialView("_KategorieFiltr", kategorie);
        }
        [ChildActionOnly]
        public ActionResult SmakiFiltr()
        {
            var smaki = db.Smaki.ToList();
            return PartialView("_SmakiFiltr", smaki);
        }
        public ActionResult Produkt(int id)
        {
            Produkt produkt = db.Produkty.Where(x => x.ProduktId == id).Include(x => x.Kategoria).FirstOrDefault();
            return View(produkt);
        }
    }
}