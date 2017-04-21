using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemWebowy.Models
{
    public class Pracownik
    {
        public int PracownikId { get; set; }
        public string ImiePracownika { get; set; }
        public string DrugieImPrac { get; set; }
        public string NazwiskoPracownika { get; set; }
        public DateTime DataUr { get; set; }
        public string LoginPrac { get; set; }
        public string HasloPrac { get; set; }
        public bool StatusKonta { get; set; }
    }
}