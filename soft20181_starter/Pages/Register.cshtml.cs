using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using soft20181_starter.Models;

namespace soft20181_starter.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly EventAppDbContext _context;
        
        [BindProperty]
        public string Name { get; set; } = string.Empty;
        
        [BindProperty]
        public string Email { get; set; } = string.Empty;
        
        [BindProperty]
        public string Password { get; set; } = string.Empty;
        
        [BindProperty]
        public string ConfirmPassword { get; set; } = string.Empty;

        public RegisterModel(EventAppDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (Password != ConfirmPassword)
            {
                ModelState.AddModelError("", "Passwords do not match");
                return Page();
            }

            if (ModelState.IsValid)
            {
                var user = new User
                {
                    Name = Name,
                    Email = Email,
                    Password = Password, // In real app, this should be hashed
                    CreatedAt = DateTime.Now
                };

                _context.Users.Add(user);
                _context.SaveChanges();

                return RedirectToPage("/Login");
            }

            return Page();
        }
    }
} 