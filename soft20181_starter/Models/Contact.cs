using System.ComponentModel.DataAnnotations;

namespace soft20181_starter.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Phone { get; set; } = string.Empty;

        [Required]
        public string Message { get; set; } = string.Empty;
    }
}
