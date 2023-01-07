using System.Text.Json.Serialization;

namespace RefereeApp.Models
{
    public class Marks
    {
        public int Id { get; set; }
        public int Mark { get; set; }
        [JsonIgnore]
        public virtual ApplicationUser User { get; set; }
        public string UserId { get; set; }

    }
}
