using HaberPortal_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace HaberPortal_API.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class HaberController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public HaberController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Haber>>> GetHaberler()
    {
        return await _context.Haberler.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Haber>> PostHaber(Haber haber)
    {
        _context.Haberler.Add(haber);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetHaber", new { id = haber.Id }, haber);
    }
}
