using Demo.BLL;
using Demo.BLL.Interfaces;
using Demo.BLL.Repositors;
using Demo.DAL.Contexts;
using Demo.DAL.Models;
using Demo.PL.MappingProfiles;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.PL
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            //Use Dependancy Injection DbContext
            services.AddDbContext<MVCAppDbContext> (options =>
                { 
                    //Add the file of Connection String 
                    options.UseSqlServer (Configuration.GetConnectionString("DefaultConnection"));
                });

            //Use Dependancy Injection For Department
            //services.AddScoped<IDepartmentRepository, DepartmentRepository>();

            //Use Dependancy Injection For Employee
            //services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            //Use Dependancy Injection For Auto Mapper
            services.AddAutoMapper(M => M.AddProfile(new EmployeeProfile()));
            services.AddAutoMapper(M => M.AddProfile(new DepartmentProfile()));

            //Use Dependancy Injection For Unit Of Work
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            #region Authentications Configurtion For Use Dependany Injection

            //Use Dependancy Injection For Identity User (Application User)
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => 
                {
                    options.LoginPath = "Account/Login";
                    options.AccessDeniedPath = "Home/Error";
                });


            //Use Dependancy Injection For implement interfaces Identity User & Identity Role
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 4;

            })
                .AddEntityFrameworkStores<MVCAppDbContext>()
                .AddDefaultTokenProviders(); 
            #endregion

        }

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

			#region Add Middleware for Authentication & Authorization 

			app.UseAuthentication();
            app.UseAuthorization(); 
            #endregion

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
