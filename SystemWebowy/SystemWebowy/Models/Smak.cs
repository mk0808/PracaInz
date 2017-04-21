using System.Collections.Generic;

namespace SystemWebowy.Models
{
    public class Smak
    {
        public int SmakId { get; set; }
        public string NazwaSmaku { get; set; }
        public virtual ICollection<Produkt> Produkty { get; set; }
    }
}