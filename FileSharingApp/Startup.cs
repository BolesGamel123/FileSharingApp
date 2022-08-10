using FileSharingApp.Areas.Admin;
using FileSharingApp.Areas.Admin.Services;
using FileSharingApp.Data;

using FileSharingApp.Services;
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

namespace FileSharingApp
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
            services.AddControllersWithViews()
                .AddViewLocalization(op =>
                      {
                op.ResourcesPath = "Resources";
                     }
           
                );

            services.AddDbContext<ApplicationDbContext>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("MyConn"));
                });

            services.AddIdentity<ApplicationUser, IdentityRole>(



                )
                .AddEntityFrameworkStores<ApplicationDbContext>();
                

        


            services.AddAuthentication()
                .AddFacebook(
                options =>
                {
                    options.AppId = Configuration["Authentication:Facebook:AppId"];
                    options.AppSecret= Configuration["Authentication:Facebook:AppSecret"];
                }
                )
                .AddGoogle(options =>
                {
                    options.ClientId = Configuration["Authentication:Google:ClientId"];
                    options.ClientSecret = Configuration["Authentication:Google:ClientSecret"];
                });
                

            services.AddTransient<IUploadService, UploadService>();
            services.AddAdminServices();
            services.AddLocalization();

            services.AddAutoMapper(typeof(Startup));
           
           

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
            var supportedCulture = new[] { "ar-SA","en-US"};
            app.UseRequestLocalization(r=> {
                r.AddSupportedUICultures(supportedCulture);
                r.AddSupportedCultures(supportedCulture);
                r.SetDefaultCulture("en-US");
            });
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
          );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

               
            });

            Rotativa.AspNetCore.RotativaConfiguration.Setup(env.WebRootPath);
        }
    }
}
