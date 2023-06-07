using DataLibrary;
using LogicLibrary;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using System.Net;

namespace MechWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddDistributedMemoryCache();

            builder.Services.AddTransient<IUserDbController, UserDbController>();
            builder.Services.AddTransient<IServicePointDbController, ServicePointDbController>();
            builder.Services.AddTransient<IRepairRequestDbController, RepairRequestDbController>();
            builder.Services.AddTransient<IMechanicDbController, MechanicDBController>();
            builder.Services.AddTransient<ICarDbController, CarDbController>();

            builder.Services.AddTransient<UserManagement>();
            builder.Services.AddTransient<ServicePointManagement>();
            builder.Services.AddTransient<RepairRequestManagement>();
            builder.Services.AddTransient<CarManagement>();
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.LoginPath = new PathString("/Login");
                options.AccessDeniedPath = new PathString("/Error");
                options.AccessDeniedPath = new PathString("/Error");
            });
            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("RepairShop",
                    policy => policy.RequireClaim("UserType", "RepairShop"));
                options.AddPolicy("CarOwner",
                    policy => policy.RequireClaim("UserType", "CarOwner"));

            });
            builder.Services.AddSession(options =>
            {
                options.Cookie.Name = "RRSession";
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapRazorPages();

            app.Run();
        }
    }
}