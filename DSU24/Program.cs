using DSU24.DAL;
using DSU24.Models.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
string conn = builder.Configuration["ConnectionStrings:Default"];
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IApiRepository, ApiRepository>();
builder.Services.AddScoped<IDbRepository, DbRepository>();

builder.Services.AddDbContext<SportDbContext>(
                o => o.UseNpgsql(conn));


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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
