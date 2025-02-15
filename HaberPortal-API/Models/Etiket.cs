namespace HaberPortal_API.Models
{
    public class Etiket
    {
        public int EtiketID { get; set; }
        public string EtiketAdi { get; set; }
        public ICollection<HaberEtiket> HaberEtiketler { get; set; }
    }
}