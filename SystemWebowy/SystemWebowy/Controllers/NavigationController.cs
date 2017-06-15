using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SystemWebowy.DataAccessLayer;

namespace SystemWebowy.Controllers
{
    public class NavigationController : Controller
    {
        // GET: Navigation
        private CukierniaDBContext db = new CukierniaDBContext();
        public NavigationController(CukierniaDBContext repo)
        {
            db = repo;
        }
        public PartialViewResult Menu()
        {
            IEnumerable<string> categories = db.Kategorie
            .Select(x => x.NazwaKategorii)
            .Distinct()
            .OrderBy(x => x);
            return PartialView(categories);
        }
    }
}