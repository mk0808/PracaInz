using System.Collections.Generic;

namespace SystemWebowy.Models
{
    public class Kategoria
    {
        public int KategoriaId { get; set; }
        public string NazwaKategorii { get; set; }
         public virtual ICollection<Produkt> Produkty { get; set; }
    }
}