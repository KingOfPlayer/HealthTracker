using HealthTracker.Infrastructure.Extentions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.ConfigureSqlConnection(builder);
builder.Services.ConfigureRepositories();
builder.Services.ConfigureServices();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(name: "default",pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(name: "api", pattern: "api/{controller=Home}/{action=Index}/{id?}");

app.Run();
