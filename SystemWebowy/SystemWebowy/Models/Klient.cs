using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SystemWebowy.Models
{
    public class Klient
    {
        public int KlientId { get; set; }

        [Required(ErrorMessage = "Wprowadz imię")]
        [StringLength(50)]
        public string Imie { get; set; }

        [StringLength(50)]
        public string DrugieImie { get; set; }

        [Required(ErrorMessage = "Wprowadz nazwisko")]
        [StringLength(50)]
        public string Nazwisko { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public DateTime DataZalozenia { get; set; }

        [Required(ErrorMessage = "Wprowadź adres e-mail.")]
        [EmailAddress(ErrorMessage = "Błędny format adresu e-mail.")]
        public string Email  { get; set; }

        [Required(ErrorMessage = "Wprowadź hasło")]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Wprowadz kod pocztowy")]
        [StringLength(6)]
        public string KodPocztowy { get; set; }

        [Required(ErrorMessage = "Wprowadź miejscowość")]
        [StringLength(50)]
        public string Miejscowosc { get; set; }

        [Required(ErrorMessage = "Wprowadź adres")]
        [StringLength(100)]
        public string Adres { get; set; }

        [RegularExpression(@"(\+\d{2})*[\d\s-]+", ErrorMessage = "Błędny format numeru telefonu.")]
        public string Telefon { get; set; }
        public bool StatusKonta { get; set; }
    }
}