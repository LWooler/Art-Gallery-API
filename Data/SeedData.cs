using Art_Gallery_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Art_Gallery_API.Data
{

    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ArtworkContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ArtworkContext>>()))
            {
                // Look for any movies.
                if (context.Artworks.Any())
                {
                    return;   // DB has been seeded
                }

                //context.Mediums.AddRange(  
                var m1 = new Medium { Name = "Watercolor" };
                var m2 = new Medium { Name = "Canvas" };
                var m3 = new Medium { Name = "Oil" };
                var m4 = new Medium { Name = "Paper" };
                //   );

                //context.Subjects.AddRange(
                var s1 = new Subject { Name = "Animal" };
                var s2 = new Subject { Name = "Landscape" };
                var s3 = new Subject { Name = "Portrait" };
                var s4 = new Subject { Name = "Person" };
                //  );

                //context.SaveChanges();

                //context.Artworks.AddRange(
                var a1 = new Artwork
                {
                    Path = "location",
                    Title = "Daylight",
                    Description = "desc",
                    //Mediums = { new Medium { Name = "Watercolor" }, new Medium { Name = "Canvas" } },
                    //Subjects = { new Subject { Name = "Animal" }, new Subject { Name = "Landscape" } },
                    Size = "10x5"
                };
                var a2 = new Artwork
                {
                    Path = "location2",
                    Title = "Sunlight",
                    Description = "desc123",
                    //Mediums = { new Medium { Name = "Oil" }, new Medium { Name = "Paper" } },
                    //Subjects = { new Subject { Name = "Portrait" }, new Subject { Name = "Person" } },
                    Size = "10x5"
                };
                //);

                context.MediumMappers.Add(new MediumMapper { Artwork = a1, Medium = m1 });
                context.MediumMappers.Add(new MediumMapper { Artwork = a1, Medium = m2 });
                context.SubjectMappers.Add(new SubjectMapper { Artwork = a1, Subject = s1 });
                context.SubjectMappers.Add(new SubjectMapper { Artwork = a1, Subject = s2 });

                context.MediumMappers.Add(new MediumMapper { Artwork = a2, Medium = m3 });
                context.MediumMappers.Add(new MediumMapper { Artwork = a2, Medium = m4 });
                context.SubjectMappers.Add(new SubjectMapper { Artwork = a2, Subject = s1 });
                context.SubjectMappers.Add(new SubjectMapper { Artwork = a2, Subject = s3 });
                context.SubjectMappers.Add(new SubjectMapper { Artwork = a2, Subject = s4 });

                context.SaveChanges();
            }
        }
    }
}
