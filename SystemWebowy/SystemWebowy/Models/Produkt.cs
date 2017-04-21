using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemWebowy.Models
{
    public class Produkt
    {
        public int ProduktId { get; set; }
        public string NazwaProduktu { get; set; }
        public string OpisProduktu { get; set; }
        public int KategoriaId { get; set; }
        public int SmakId { get; set; }
        public bool Dostepnosc { get; set; }
        public decimal CenaS { get; set; }
        public decimal CenaM { get; set; }
        public decimal CenaL { get; set; }
        public virtual ICollection<Zdjecie> Zdjecia { get; set; }
        public virtual Kategoria Kategoria { get; set; }
        public virtual Smak Samk { get; set; }

    }
}