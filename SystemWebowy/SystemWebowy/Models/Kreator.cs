using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemWebowy.Models
{
    public class Kreator
    {
        public int KreatorId { get; set; }
        public int LiczbaPieter { get; set; }
        public string Wielkosc { get; set; }
        public string Kształt { get; set; }
        public string Biszkopt { get; set; }
        public string Nadzienie { get; set; }
        public string Smak { get; set; }
        public string Polewa { get; set; }
        public string Dekoracja { get; set; }
        public string Kolor { get; set; }
        public string Dodatki { get; set; }
        public string Uwagi { get; set; }
        public decimal Wycena { get; set; }
    }
}