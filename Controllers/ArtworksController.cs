using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Art_Gallery_API.Data;
using Art_Gallery_API.Models;

namespace Art_Gallery_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtworksController : ControllerBase
    {
        private readonly ArtworkContext _context;

        public ArtworksController(ArtworkContext context)
        {
            _context = context;
        }

        // GET: api/Artworks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Artwork>>> GetArtworks()
        {
          if (_context.Artworks == null)
          {
              return NotFound();
          }
            return await _context.Artworks.Include(x => x.SubjectMappers).ThenInclude(x => x.Subject).Include(x => x.MediumMappers).ThenInclude(x => x.Medium).ToListAsync();
        }

        // GET: api/Artworks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Artwork>> GetArtwork(int id)
        {
          if (_context.Artworks == null)
          {
              return NotFound();
          }
            var artwork = await _context.Artworks.Include(x => x.SubjectMappers).ThenInclude(x => x.Subject).Include(x => x.MediumMappers).ThenInclude(x => x.Medium).Where(x => x.ArtworkId == id).FirstOrDefaultAsync();

            if (artwork == null)
            {
                return NotFound();
            }

            return artwork;
        }
    }
}
