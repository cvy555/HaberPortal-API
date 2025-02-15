using HaberPortal_API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Haber> Haberler { get; set; }
    public DbSet<Kategori> Kategoriler { get; set; }
    public DbSet<Yorum> Yorumlar { get; set; }
    public DbSet<Gorsel> Gorseller { get; set; }
    public DbSet<Etiket> Etiketler { get; set; }
    public DbSet<HaberEtiket> HaberEtiketler { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Kullanıcı ve Haberler arasındaki ilişkiyi tanımlayın
        builder.Entity<ApplicationUser>()
            .HasMany(u => u.Haberler)
            .WithOne(h => h.Yazar)
            .HasForeignKey(h => h.YazarId);

        // Diğer tablolar ve ilişkiler
        builder.Entity<Haber>()
            .HasOne(h => h.Kategori)
            .WithMany(k => k.Haberler)
            .HasForeignKey(h => h.KategoriId);

        builder.Entity<Haber>()
            .HasMany(h => h.Gorseller)
            .WithOne(g => g.Haber)
            .HasForeignKey(g => g.HaberID);

        builder.Entity<Haber>()
            .HasMany(h => h.Yorumlar)
            .WithOne(y => y.Haber)
            .HasForeignKey(y => y.HaberID);

        builder.Entity<HaberEtiket>()
            .HasKey(he => new { he.HaberID, he.EtiketID });

        builder.Entity<HaberEtiket>()
            .HasOne(he => he.Haber)
            .WithMany(h => h.HaberEtiketler)
            .HasForeignKey(he => he.HaberID);

        builder.Entity<HaberEtiket>()
            .HasOne(he => he.Etiket)
            .WithMany(e => e.HaberEtiketler)
            .HasForeignKey(he => he.EtiketID);
    }
}
