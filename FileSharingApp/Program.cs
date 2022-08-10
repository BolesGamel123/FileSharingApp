using FileSharingApp.Areas.Admin.Services;
using FileSharingApp.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileSharingApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using (var scope =host.Services.CreateScope())
            {
                var Provider = scope.ServiceProvider;

               // var dbcontext = Provider.GetRequiredService<ApplicationDbContext>();

              //  dbcontext.Database.Migrate();

                var UserService = Provider.GetRequiredService<IUserService>();
                await UserService.InitializeAsync();

            }
 
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
