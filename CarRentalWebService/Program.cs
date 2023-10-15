using Microsoft.EntityFrameworkCore;
using CarRentalWebService.Data;
using CarRentalWebService.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ConnectionContext>(option => option.UseMySql("server=localhost;initial catalog=carloan;uid=root;pwd=databasehebert",
Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.34-mysql")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<AdminService>();

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
