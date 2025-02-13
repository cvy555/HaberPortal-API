using AutoMapper;
using HaberPortal_API.Models;
using HaberPortal_API.DTOs;

namespace HaberPortal_API.Profiles
{
    public class HaberProfile : Profile
    {
        public HaberProfile()
        {
            // HaberDTO -> Haber
            CreateMap<HaberDTO, Haber>()
                .ForMember(dest => dest.Tarih, opt => opt.MapFrom(_ => DateTime.Now));

            // Haber -> HaberDetayDTO
            CreateMap<Haber, HaberDetayDTO>()
                .ForMember(dest => dest.KategoriAd, opt => opt.MapFrom(src => src.Kategori.Ad))
                .ForMember(dest => dest.YazarAdSoyad, opt => opt.MapFrom(src => src.Yazar.AdSoyad));
        }
    }
}