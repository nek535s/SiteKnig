using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using SiteKnig.Data;
using SiteKnig.Interfaces;
using SiteKnig.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DbBooksContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("BooksCon"));
});
builder.Services.AddScoped<IBookSortingService, BookSortingService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=BooksMVC}/{action=Index}/{id?}");

app.Run();
