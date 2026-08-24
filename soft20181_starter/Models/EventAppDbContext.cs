using Microsoft.EntityFrameworkCore;

namespace soft20181_starter.Models;

// Database context
public class EventAppDbContext : DbContext
{
    public EventAppDbContext(DbContextOptions<EventAppDbContext> options)
        : base(options)
    {
    }

    // Database tables
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<TheEvent> Events { get; set; }
    public DbSet<AttendingList> AttendingLists { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
