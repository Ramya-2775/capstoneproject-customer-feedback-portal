using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using capstone_project.Data;

var builder = WebApplication.CreateBuilder(args);

// Database Context
builder.Services.AddDbContext<capstone_projectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("capstone_projectContext")
    ?? throw new InvalidOperationException("Connection string 'capstone_projectContext' not found.")));

// Add services to the container
builder.Services.AddControllersWithViews();

// ✅ Add session services
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); 
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

// ✅ Add session middleware
app.UseSession(); // 🔥 This line is MANDATORY before authorization

app.UseAuthorization();

// Map routes
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();