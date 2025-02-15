namespace HaberPortal_API.DTOs
{
    public class HaberDTO
    {
        public string Baslik { get; set; } = string.Empty;
        public string Icerik { get; set; } = string.Empty;
        public int KategoriId { get; set; }
        public string ResimUrl { get; set; } = string.Empty;
        public DateTime YayinlanmaTarihi { get; set; } // Eklendi
    }

    public class HaberDetayDTO
    {
        public int Id { get; set; } 
        public string Baslik { get; set; } = string.Empty;
        public string Icerik { get; set; } = string.Empty;
        public DateTime YayinlanmaTarihi { get; set; } // İsim değiştirildi
        public string KategoriAd { get; set; } = string.Empty;
        public string YazarAdSoyad { get; set; } = string.Empty;
        public string ResimUrl { get; set; } = string.Empty;
    }
}
