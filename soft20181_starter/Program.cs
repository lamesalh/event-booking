using Microsoft.EntityFrameworkCore;
using soft20181_starter.Models;
using soft20181_starter.Services;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add Razor Pages
builder.Services.AddRazorPages();

// Database setup
builder.Services.AddDbContext<EventAppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("Default")));

// Authentication setup
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Login";
        options.LogoutPath = "/Logout";
        options.ExpireTimeSpan = TimeSpan.FromHours(24);
    });

// Add data seeding service
builder.Services.AddScoped<DataSeedingService>();

var app = builder.Build();

// Seed database with sample data
using (var scope = app.Services.CreateScope())
{
    var seedingService = scope.ServiceProvider.GetRequiredService<DataSeedingService>();
    seedingService.SeedData();
}

// Configure middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
