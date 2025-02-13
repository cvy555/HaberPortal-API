using Microsoft.AspNetCore.Mvc;

namespace HaberPortal_API.Models
{
    public class Haber 
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public DateTime Tarih { get; set; }
        public int KategoriId { get; set; }  // İlişki için
        public string ResimUrl { get; set; }
        public string YazarId { get; set; }  // Kullanıcı ilişkisi
    }
}
