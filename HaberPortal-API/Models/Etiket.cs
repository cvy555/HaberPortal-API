namespace HaberPortal_API.Models
{
    public class Etiket
    {
        public int EtiketID { get; set; }
        public string EtiketAdi { get; set; } = string.Empty ;
        public ICollection<HaberEtiket> HaberEtiketler { get; set; } = new List<HaberEtiket>();
    }
}