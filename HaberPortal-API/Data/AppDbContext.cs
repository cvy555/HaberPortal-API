using HaberPortal_API.Models;
using Microsoft.EntityFrameworkCore;

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Haber>()
        .HasOne(h => h.Kategori)
        .WithMany(k => k.Haberler)
        .HasForeignKey(h => h.KategoriId);

    modelBuilder.Entity<Haber>()
        .HasOne(h => h.Yazar)
        .WithMany(u => u.Haberler)
        .HasForeignKey(h => h.YazarId);
}