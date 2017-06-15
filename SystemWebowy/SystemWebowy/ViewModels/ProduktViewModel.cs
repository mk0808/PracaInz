using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SystemWebowy.Models;

namespace SystemWebowy.ViewModels
{
    public class ProduktViewModel
    {
        public IEnumerable<Produkt> Produkty { get; set; }

        public Produkt Produkt { get; set; }
        public IEnumerable<Kategoria> Kategorie { get; set; }
        public Kategoria Kategoria { get; set; }
        public IEnumerable<Smak> Smaki { get; set; }
    }
}