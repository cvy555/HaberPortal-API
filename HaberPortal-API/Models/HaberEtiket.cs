namespace HaberPortal_API.Models
{
    public class HaberEtiket
    {
        public int HaberID { get; set; }
        public int EtiketID { get; set; }
        public Haber Haber { get; set; }
        public Etiket Etiket { get; set; }
    }
}