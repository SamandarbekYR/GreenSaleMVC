using GreenSaleMVC.BLL.Interfaces;
using GreenSaleMVC.BLL.Services;
using GreenSaleMVC.Data;
using GreenSaleMVC.Data.Interfaces;
using GreenSaleMVC.Data.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LocalDB")));
builder.Services.AddTransient<ICategoryInterface, CategoryRepository>();
builder.Services.AddTransient<ICategoryService ,AddCategoryRepository>();
builder.Services.AddTransient<IFileService,FileService>();
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
