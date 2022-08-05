using Newtonsoft.Json;

namespace Art_Gallery_API.Models
{
    public class Medium
    {
        public int MediumId { get; set; }
        [JsonIgnore]
        public virtual ICollection<MediumMapper> MediumMappers { get; set; }
        public string Name { get; set; }
    }
}