using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using soft20181_starter.Models;

namespace soft20181_starter.Pages;

// Contact page model
public class ContactModel : PageModel
{
    private readonly EventAppDbContext _context;
    
    [BindProperty]
    public Contact ContactInfo { get; set; } = new();

    public ContactModel(EventAppDbContext context)
    {
        _context = context;
    }

    public void OnGet()
    {
    }

    // Handle contact form submission
    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            _context.Contacts.Add(ContactInfo);
            _context.SaveChanges();
            return RedirectToPage();
        }
        return Page();
    }
}
