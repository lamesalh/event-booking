using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using soft20181_starter.Models;

namespace soft20181_starter.Pages;

// Event detail page model
public class EventDetailModel : PageModel
{
    private readonly EventAppDbContext _context;
    
    public TheEvent Event { get; set; } = null!;

    public EventDetailModel(EventAppDbContext context)
    {
        _context = context;
    }

    // Get event by ID
    public IActionResult OnGet(int id)
    {
        Event = _context.Events.FirstOrDefault(e => e.Id == id)!;
        if (Event == null)
        {
            return NotFound();
        }
        return Page();
    }
} 