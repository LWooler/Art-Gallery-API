namespace Art_Gallery_API.Models
{
    public class Artwork
    {
        public int ArtworkId { get; set; }
        public string Path { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual ICollection<MediumMapper> MediumMappers { get; set; }
        public virtual ICollection<SubjectMapper> SubjectMappers { get; set; }
        public string Size { get; set; }
    }
}
