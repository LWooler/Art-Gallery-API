//using Newtonsoft.Json;

using Newtonsoft.Json;

namespace Art_Gallery_API.Models
{
    public class MediumMapper
    {
        public int MediumMapperId { get; set; }
        [JsonIgnore]
        public int MediumId { get; set; }
        [JsonIgnore]
        public int ArtworkId { get; set; }
        public virtual Medium Medium { get; set; }
        public virtual Artwork Artwork { get; set; }
    }
}
