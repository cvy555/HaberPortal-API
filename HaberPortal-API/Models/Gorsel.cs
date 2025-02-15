namespace HaberPortal_API.Models
{
    public class Gorsel
    {
        public int GorselID { get; set; }
        public int HaberID { get; set; }
        public string DosyaAdi { get; set; }
        public DateTime YuklenmeTarihi { get; set; }
        public Haber Haber { get; set; }
    }
}