namespace RefereeApp.Models.ApiModels
{
    public class UpdateEventRequest
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Name { get; set; }
        public bool AllDay { get; set; }

        public ApplicationUser User { get; set; }

    }
}
