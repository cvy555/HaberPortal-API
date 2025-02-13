using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HaberPortal_API.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string AdSoyad { get; set; }
        public List<Haber> Haberler { get; set; }  // Kullanıcının yazdığı haberler
    }
}
