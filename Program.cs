using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Task_Management_Web.Data;
using Task_Management_Web.Repository.Class;
using Task_Management_Web.Repository.Interface;
using Task_Management_Web.Services.Class;
using Task_Management_Web.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppdbContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("dbcs")));

builder.Services.AddScoped<IAddUser_Repository,AddUser_Repository>();
builder.Services.AddScoped<IAddUser_Services,AddUser_Services>();
builder.Services.AddSession();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseSession();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=AddUser}/{id?}")
    .WithStaticAssets();


app.Run();
