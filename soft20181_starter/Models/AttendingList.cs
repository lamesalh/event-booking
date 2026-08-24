using System.ComponentModel.DataAnnotations;

namespace soft20181_starter.Models
{
    public class AttendingList
    {
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public int EventId { get; set; }
        public TheEvent Event { get; set; } = null!;
    }
} 