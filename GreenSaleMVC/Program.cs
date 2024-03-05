using AutoMapper;
using GreenSaleMVC.BLL.Common;
using GreenSaleMVC.BLL.Interfaces;
using GreenSaleMVC.BLL.Interfaces.Messages;
using GreenSaleMVC.BLL.Services;
using GreenSaleMVC.BLL.Services.Bot;
using GreenSaleMVC.BLL.Services.Messages;
using GreenSaleMVC.Data;
using GreenSaleMVC.Data.Interfaces;
using GreenSaleMVC.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using Telegram.Bot;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("LocalDB")));

var botConfig = builder.Configuration.GetSection("BotConfiguration")
    .Get<BotConfiguration>();

builder.Services.AddTransient<IFileService,FileService>();
builder.Services.AddTransient<BotService>();
builder.Services.AddTransient<IMessageService, MessageService>();
builder.Services.AddTransient<IUnitOfWork,UnitOfWork>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
builder.Services.AddAuthentication()
    .AddCookie("Admin", config =>
    {
        config.LoginPath = "/admin/auth/login";
    })
    .AddCookie("User", config =>
    {
        config.LoginPath = "/auth/login";
    });

var mapConfig = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new AutoMapperProfile());

});

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
       name: "admin",
       pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
