using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using soft20181_starter.Models;
using System.Collections.Generic;
using System.Linq;

namespace soft20181_starter.Pages
{
    public class AttendingListModel : PageModel
    {
        private readonly EventAppDbContext _context;
        public List<AttendingList> AttendingEvents { get; set; } = new List<AttendingList>();

        public AttendingListModel(EventAppDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            // For minimum requirement - show all attending events
            AttendingEvents = _context.AttendingLists
                .Include(a => a.Event)
                .ToList();
        }

        public IActionResult OnPostRemove(int id)
        {
            var attending = _context.AttendingLists.Find(id);
            if (attending != null)
            {
                _context.AttendingLists.Remove(attending);
                _context.SaveChanges();
            }
            return RedirectToPage();
        }
    }
} 