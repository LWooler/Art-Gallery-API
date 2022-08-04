namespace Art_Gallery_API.Models
{
    public class Artwork
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<string> Medium { get; set; }
        public ICollection<string> Subject { get; set; }
        public string Size { get; set; }
    }
}
