using Microsoft.EntityFrameworkCore;
using Art_Gallery_API.Models;

namespace Art_Gallery_API.Data
{
    public class ArtworkContext : DbContext
    {
        public ArtworkContext(DbContextOptions<ArtworkContext> options) : base(options)
        {
        }

        public DbSet<Artwork> Artworks { get; set; }
    }
}
