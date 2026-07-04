namespace TicketingSystem.UI.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Status { get; set; } = "Open";
        public string Priority { get; set; } = "Low";
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public int? CreatedByUserId { get; set; }
        public string? CreatedByName { get; set; }
        public int? AssignedToUserId { get; set; }
        public string? AssignedToName { get; set; }
        public int CommentCount { get; set; }
    }
}