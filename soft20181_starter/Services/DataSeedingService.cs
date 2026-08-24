using Microsoft.EntityFrameworkCore;
using soft20181_starter.Models;

namespace soft20181_starter.Services;

// Service to add sample data to database
public class DataSeedingService
{
    private readonly EventAppDbContext _context;

    public DataSeedingService(EventAppDbContext context)
    {
        _context = context;
    }

    // Add sample events if database is empty
    public void SeedData()
    {
        if (!_context.Events.Any())
        {
            var events = new List<TheEvent>
            {
                new()
                {
                    Name = "Drake",
                    Description = "Experience an unforgettable night with Drake, the global sensation known for his chart-topping hits like 'God's Plan' and 'One Dance.'",
                    Location = "O2 Arena - London",
                    EventDateTime = new DateTime(2025, 6, 15),
                    CoverPhoto = "/images/drake.jpeg"
                },
                new()
                {
                    Name = "21 Savage",
                    Description = "Dive into the world of 21 Savage, a trailblazer in modern hip-hop. His performances are raw, real, and unforgettable.",
                    Location = "Madison Square Garden - New York",
                    EventDateTime = new DateTime(2025, 7, 8),
                    CoverPhoto = "/images/21savage.jpeg"
                },
                new()
                {
                    Name = "Baby Gang",
                    Description = "Join Baby Gang as he takes the stage in a thrilling showcase of his unique style and captivating flow.",
                    Location = "Wembley Stadium - London",
                    EventDateTime = new DateTime(2025, 8, 12),
                    CoverPhoto = "/images/babygang.jpeg"
                },
                new()
                {
                    Name = "Bad Bunny",
                    Description = "Feel the energy of Bad Bunny, the global icon of Latin music. From reggaeton to trap, he brings infectious beats and passion.",
                    Location = "Staples Center - Los Angeles",
                    EventDateTime = new DateTime(2025, 9, 20),
                    CoverPhoto = "/images/badbunny.jpeg"
                },
                new()
                {
                    Name = "Adele",
                    Description = "Experience the soulful magic of Adele as she performs her powerful ballads that have touched millions worldwide.",
                    Location = "TD Garden - Boston",
                    EventDateTime = new DateTime(2026, 3, 3),
                    CoverPhoto = "/images/adele.jpeg"
                },
                new()
                {
                    Name = "The Weeknd",
                    Description = "Celebrate Valentine's Day with The Weeknd. Enjoy his mesmerizing voice and hits like 'Blinding Lights' and 'Starboy.'",
                    Location = "Manchester Arena - Manchester",
                    EventDateTime = new DateTime(2026, 2, 14),
                    CoverPhoto = "/images/theweeknd.jpeg"
                },
                new()
                {
                    Name = "Travis",
                    Description = "Get hyped for Travis Scott's high-octane performance, blending hip-hop with immersive visuals. Known for 'SICKO MODE.'",
                    Location = "O2 Arena - London",
                    EventDateTime = new DateTime(2025, 10, 5),
                    CoverPhoto = "/images/travis.jpeg"
                },
                new()
                {
                    Name = "Morad",
                    Description = "Discover Morad's unique style, combining deep storytelling with urban beats. His music resonates worldwide.",
                    Location = "Barclays Center - New York",
                    EventDateTime = new DateTime(2025, 11, 18),
                    CoverPhoto = "/images/morad.jpeg"
                },
                new()
                {
                    Name = "Rossalia",
                    Description = "Join Rosalia for a night of genre-bending music, where flamenco meets pop and reggaeton. Her performances are vibrant.",
                    Location = "Sofi Stadium - Los Angeles",
                    EventDateTime = new DateTime(2025, 12, 2),
                    CoverPhoto = "/images/rossalia.jpeg"
                },
                new()
                {
                    Name = "Rema",
                    Description = "Catch Rema, the Nigerian superstar redefining Afrobeat with hits like 'Calm Down' and 'Dumebi.'",
                    Location = "Emirates Stadium - Manchester",
                    EventDateTime = new DateTime(2026, 1, 10),
                    CoverPhoto = "/images/rema.jpeg"
                }
            };

            _context.Events.AddRange(events);
            _context.SaveChanges();
        }
    }
} 