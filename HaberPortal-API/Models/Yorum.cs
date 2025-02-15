namespace HaberPortal_API.Models
{
    public class Yorum
    {
        public int YorumID { get; set; }
        public int HaberID { get; set; }
        public string KullaniciID { get; set; }
        public string Icerik { get; set; }  // Bu satırı 'Yorum' olarak değiştirmeyin
        public DateTime Tarih { get; set; }
        public Haber Haber { get; set; }
        public ApplicationUser Kullanici { get; set; }
    }
}
