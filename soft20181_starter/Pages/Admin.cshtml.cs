using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using soft20181_starter.Models;

namespace soft20181_starter.Pages;

// Admin page model
public class AdminModel : PageModel
{
    private readonly EventAppDbContext _context;
    
    public List<TheEvent> Events { get; set; } = new();
    public List<User> Users { get; set; } = new();
    
    [BindProperty]
    public TheEvent NewEvent { get; set; } = new();

    public AdminModel(EventAppDbContext context)
    {
        _context = context;
    }

    // Get all events and users
    public void OnGet()
    {
        Events = _context.Events.ToList();
        Users = _context.Users.ToList();
    }

    // Add new event
    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            _context.Events.Add(NewEvent);
            _context.SaveChanges();
            return RedirectToPage();
        }
        
        return Page();
    }

    // Delete event
    public IActionResult OnGetDelete(int id)
    {
        var eventToDelete = _context.Events.Find(id);
        if (eventToDelete != null)
        {
            _context.Events.Remove(eventToDelete);
            _context.SaveChanges();
        }
        
        return RedirectToPage();
    }

    // Delete user
    public IActionResult OnGetDeleteUser(int id)
    {
        var userToDelete = _context.Users.Find(id);
        if (userToDelete != null)
        {
            _context.Users.Remove(userToDelete);
            _context.SaveChanges();
        }
        
        return RedirectToPage();
    }
} 