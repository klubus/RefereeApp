using System.Text.Json.Serialization;

namespace RefereeApp.Models
{
    public class Finances
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public bool Paid { get; set; } = false;

        public DateTime DateOfInvoices { get; set; }
        [JsonIgnore]
        public virtual ApplicationUser User { get; set; }
        public string UserId { get; set; }
    }
}
