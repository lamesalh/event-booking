using System.ComponentModel.DataAnnotations;

namespace soft20181_starter.Models;

// Event model for storing concert information
public class TheEvent
{
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; } = string.Empty;
    
    [Required]
    public string Description { get; set; } = string.Empty;
    
    [Required]
    public string Location { get; set; } = string.Empty;
    
    public DateTime EventDateTime { get; set; }
    
    [Required]
    public string CoverPhoto { get; set; } = string.Empty;
} 