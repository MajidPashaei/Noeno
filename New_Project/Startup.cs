using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace New_Project {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services) {

            services.AddControllersWithViews ();
           
            services.AddSession();

             services.AddHttpContextAccessor();

            services.AddMvc ().AddRazorRuntimeCompilation ();

            services.AddDbContext<Context_db> (option => {
                option.UseSqlServer (Configuration.GetConnectionString ("DefaultConnection"));

            });


            services.AddAuthentication (options => {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie (options => {
                options.LoginPath = "/Home/index";
                options.LogoutPath = "/Home/index";
                options.ExpireTimeSpan = TimeSpan.FromMinutes (43200);
            });







           

            services.Configure<FormOptions> (options => {
                options.ValueLengthLimit = int.MaxValue;
                options.MultipartBodyLengthLimit = long.MaxValue;
            });
            /////////////auto
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
                // app.UseExceptionHandler ("/Home/Error");
                // // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                // app.UseHsts ();
            } else {
                app.UseDeveloperExceptionPage();
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
               
            }


            app.UseHttpsRedirection ();
            app.UseStaticFiles ();
            app.UseRouting ();
            app.UseAuthentication ();
            app.UseAuthorization ();
            app.UseSession();

           
              
               app.UseEndpoints (endpoints => {

                endpoints.MapAreaControllerRoute (
                    name: "Areas",
                    areaName:"driver",
                    pattern: "driver/{controller=Home}/{action=privacy}/{id?}");

                     endpoints.MapAreaControllerRoute (
                    name: "Areas",
                    areaName:"Admin",
                    pattern: "Admin/{controller=Home}/{action=index}/{id?}");


                endpoints.MapControllerRoute (
                    name: "default",
                    pattern: "{controller=Home}/{action=index}/{id?}");
               
            });




      
        }
    }
}