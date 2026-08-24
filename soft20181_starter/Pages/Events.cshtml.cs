using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using soft20181_starter.Models;

namespace soft20181_starter.Pages;

// Events page model
public class EventsModel : PageModel
{
    private readonly EventAppDbContext _context;
    
    public List<TheEvent> Events { get; set; } = new();

    public EventsModel(EventAppDbContext context)
    {
        _context = context;
    }

    // Get all events from database
    public void OnGet()
    {
        Events = _context.Events.ToList();
    }

    // Add event to attending list (not fully implemented)
    public IActionResult OnPostAddToAttendingList(int id)
    {
        // TODO: Need to implement user authentication
        return RedirectToPage();
    }
} 