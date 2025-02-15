namespace HaberPortal_API.Models
{
    public class Yorum
    {
        public int YorumID { get; set; }
        public int HaberID { get; set; }
        public string KullaniciID { get; set; } = string.Empty;
        public string Icerik { get; set; } = string.Empty; // Bu satırı 'Yorum' olarak değiştirmeyin
        public DateTime Tarih { get; set; }
        public Haber Haber { get; set; } = new Haber();
        public ApplicationUser Kullanici { get; set; } = new ApplicationUser();
    }
}
