namespace SystemWebowy.Models
{
    public class PozycjaZamowieniaSpec
    {
        public int PozycjaZamowieniaSpecId { get; set; }
        public int ZamowienieId { get; set; }
        public int KreatorId { get; set; }
        public int Ilosc { get; set; }
        public decimal CenaZakupu { get; set; }
        public virtual Kreator Kreator { get; set; }
        public virtual Zamowienie Zamowienie { get; set; }
    }
}