using HaberPortal_API.Models;

public class Haber
{
    public int Id { get; set; }
    public string Baslik { get; set; } = string.Empty;  // Varsayılan değer atandı
    public string KisaAciklama { get; set; } = string.Empty;  // Varsayılan değer atandı
    public string Icerik { get; set; } = string.Empty;  // Varsayılan değer atandı
    public int KategoriId { get; set; }
    public Kategori Kategori { get; set; } = new Kategori();  // Varsayılan değer atandı
    public string YazarId { get; set; } = string.Empty;  // Varsayılan değer atandı
    public ApplicationUser Yazar { get; set; } = new ApplicationUser();  // Varsayılan değer atandı
    public string ResimUrl { get; set; } = string.Empty;  // Varsayılan değer atandı
    public DateTime YayinlanmaTarihi { get; set; }
    public int GoruntulenmeSayisi { get; set; }
    public bool AktifMi { get; set; }
    public ICollection<Gorsel> Gorseller { get; set; } = new List<Gorsel>();  // Varsayılan değer atandı
    public ICollection<Yorum> Yorumlar { get; set; } = new List<Yorum>();  // Varsayılan değer atandı
    public ICollection<HaberEtiket> HaberEtiketler { get; set; } = new List<HaberEtiket>();  // Varsayılan değer atandı
}
