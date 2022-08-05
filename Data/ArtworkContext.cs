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
        public DbSet<Medium> Mediums { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<MediumMapper> MediumMappers { get; set; }
        public DbSet<SubjectMapper> SubjectMappers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SubjectMapper>()
                .HasOne(bc => bc.Artwork)
                .WithMany(b => b.SubjectMappers)
                .HasForeignKey(bc => bc.ArtworkId);
            modelBuilder.Entity<SubjectMapper>()
                .HasOne(bc => bc.Subject)
                .WithMany(c => c.SubjectMappers)
                .HasForeignKey(bc => bc.SubjectId);

            modelBuilder.Entity<MediumMapper>()
                .HasOne(bc => bc.Artwork)
                .WithMany(b => b.MediumMappers)
                .HasForeignKey(bc => bc.ArtworkId);
            modelBuilder.Entity<MediumMapper>()
                .HasOne(bc => bc.Medium)
                .WithMany(c => c.MediumMappers)
                .HasForeignKey(bc => bc.MediumId);
        }
    }
}
