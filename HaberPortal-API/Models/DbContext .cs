using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using HaberPortal_API.Models; // ApplicationUser sınıfının namespace'i

namespace HaberPortal_API.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        // DbContextOptions parametresini base sınıfa ileten constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Haber> Haberler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
    }
}