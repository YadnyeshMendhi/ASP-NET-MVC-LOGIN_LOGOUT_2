using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ASP_NET_MVC_LOGIN_LOGOUT_2.Areas.Identity.Data;
using ASP_NET_MVC_LOGIN_LOGOUT_2.Models;
using Microsoft.Extensions.Options;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'ASP_NET_MVC_LOGIN_LOGOUT_2ContextConnection' not found.");

builder.Services.AddDbContext<ASP_NET_MVC_LOGIN_LOGOUT_2.Areas.Identity.Data.DbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<ASP_NET_MVC_LOGIN_LOGOUT_2User>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ASP_NET_MVC_LOGIN_LOGOUT_2.Areas.Identity.Data.DbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ASP_NET_MVC_LOGIN_LOGOUT_2.Areas.Identity.Data.DbContext>(Options =>
Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
