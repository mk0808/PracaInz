using System.Collections.Generic;

namespace SystemWebowy.Models
{
    public class Dostawa
    {
        public int DostawaId { get; set; }
        public string RodzajDostawy { get; set; }
        public decimal KosztDostawy { get; set; }
        public virtual ICollection<Zamowienie> Zamowienia { get; set; }
    }
}