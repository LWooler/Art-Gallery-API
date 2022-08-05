using Newtonsoft.Json;

namespace Art_Gallery_API.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        [JsonIgnore]
        public virtual ICollection<SubjectMapper> SubjectMappers { get; set; }
        public string Name { get; set; }
    }
}