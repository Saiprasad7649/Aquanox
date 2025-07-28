var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // 30-day HSTS for production
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // Serve CSS, JS, images from wwwroot

app.UseRouting();

app.UseAuthorization();

//  ROUTING FOR AREAS (ADMIN)
app.MapAreaControllerRoute(
    name: "admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

// DEFAULT ROUTING (CLIENT)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
