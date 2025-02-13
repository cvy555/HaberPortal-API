using Microsoft.AspNetCore.Mvc;

namespace HaberPortal_API.Models
{
    public class Kategori 
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public List<Haber> Haberler { get; set; }  // Haber ile ilişki
    
}
}
