namespace SystemWebowy.Models
{
    public class Zdjecie
    {
        public int ZdjecieId { get; set; }
        public byte[] Zdj { get; set; }
        public string ImageMimeType { get; set; }
        public virtual Produkt Produkt { get; set; }
    }
}