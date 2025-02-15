using HaberPortal_API.Models;

public class Haber
{
    public int Id { get; set; }
    public string Baslik { get; set; }
    public string KisaAciklama { get; set; }
    public string Icerik { get; set; }
    public int KategoriId { get; set; }
    public Kategori Kategori { get; set; }
    public string YazarId { get; set; }
    public ApplicationUser Yazar { get; set; }
    public string ResimUrl { get; set; }
    public DateTime YayinlanmaTarihi { get; set; }
    public int GoruntulenmeSayisi { get; set; }
    public bool AktifMi { get; set; }
    public ICollection<Gorsel> Gorseller { get; set; }  // Bu satırı ekleyin
    public ICollection<Yorum> Yorumlar { get; set; }  // Bu satırı ekleyin
    public ICollection<HaberEtiket> HaberEtiketler { get; set; }  // Bu satırı ekleyin
}
