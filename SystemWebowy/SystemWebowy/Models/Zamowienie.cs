using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemWebowy.Models
{
    public class Zamowienie
    {
        public int ZamowienieId { get; set; }
        public DateTime DataZamowienia { get; set; }
        public decimal KwotaZaplaty { get; set; }
        public Platnosc Platnosc { get; set; }
        public int DostawaId { get; set; }
        public string Uwagi { get; set; }
        public int KlientId { get; set; }
        public DateTime DataDoreczenia { get; set; }
        public TimeSpan GodzinaDoreczenia { get; set; }
        public StatusZamowienia StatusZamowienia { get; set; }
        public virtual Dostawa Dostawa { get; set; }
        public List<PozycjaZamowienia> PozycjeZamowienia { get; set; }
        public List<PozycjaZamowieniaSpec> PozycjeZamowieniaSpec { get; set; }
    }

    public enum StatusZamowienia
    {
        Nowe, 
        Realizacja,
        Zrealizowane,
        Anulowane
    }
    public enum Platnosc
    {
        Karta,
        Przelew,
        Gotówka
    }
}