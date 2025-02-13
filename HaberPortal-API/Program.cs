using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using HaberPortal_API.Data; // AppDbContext'in namespace'i
using HaberPortal_API.Models; // ApplicationUser'ın namespace'i

var builder = WebApplication.CreateBuilder(args);

// DbContext ve Identity konfigürasyonu
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

// JWT için ekstra ayarlar (opsiyonel)
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

builder.Services.AddControllers();