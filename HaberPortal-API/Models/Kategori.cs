using Microsoft.AspNetCore.Mvc;

namespace HaberPortal_API.Models
{
    public class Kategori 
    {
        public int Id { get; set; } 
        public string Ad { get; set; } = string.Empty;
        public List<Haber> Haberler { get; set; } = new List<Haber>(); // Haber ile ilişki

    }
}
