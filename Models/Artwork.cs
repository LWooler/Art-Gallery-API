namespace Art_Gallery_API.Models
{
    public class Artwork
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Mediums> Mediums { get; set; }
        public virtual ICollection<string> Subject { get; set; }
        public string Size { get; set; }
    }
}
