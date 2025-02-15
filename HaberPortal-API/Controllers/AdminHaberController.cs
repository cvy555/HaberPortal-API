using HaberPortal_API.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace HaberPortal_API.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class AdminHaberController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AdminHaberController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Haber>>> GetHaberler()
        {
            return await _context.Haberler.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Haber>> CreateHaber(HaberDTO haberDto)
        {
            var haber = new Haber
            {
                Baslik = haberDto.Baslik,
                Icerik = haberDto.Icerik,
                KategoriId = haberDto.KategoriId,
                YayinlanmaTarihi = haberDto.YayinlanmaTarihi,
                AktifMi = true
            };

            _context.Haberler.Add(haber);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetHaberler), new { id = haber.Id }, haber);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHaber(int id, HaberDTO haberDto)
        {
            var haber = await _context.Haberler.FindAsync(id);

            if (haber == null)
            {
                return NotFound();
            }

            haber.Baslik = haberDto.Baslik;
            haber.Icerik = haberDto.Icerik;
            haber.KategoriId = haberDto.KategoriId;
            haber.YayinlanmaTarihi = haberDto.YayinlanmaTarihi;

            _context.Haberler.Update(haber);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHaber(int id)
        {
            var haber = await _context.Haberler.FindAsync(id);

            if (haber == null)
            {
                return NotFound();
            }

            _context.Haberler.Remove(haber);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
