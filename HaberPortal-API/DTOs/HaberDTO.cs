namespace HaberPortal_API.DTOs
{
    public class HaberDTO
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public int KategoriId { get; set; }
        public string ResimUrl { get; set; }
    }

    public class HaberDetayDTO
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public DateTime Tarih { get; set; }
        public string KategoriAd { get; set; } // Kategori bilgisi
        public string YazarAdSoyad { get; set; } // Yazar bilgisi
        public string ResimUrl { get; set; }
    }
}

