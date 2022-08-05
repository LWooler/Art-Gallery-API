using Newtonsoft.Json;

namespace Art_Gallery_API.Models
{
    public class SubjectMapper
    {
        public int SubjectMapperId { get; set; }
        [JsonIgnore]
        public int SubjectId { get; set; }
        [JsonIgnore]
        public int ArtworkId { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Artwork Artwork { get; set; }
    }
}
