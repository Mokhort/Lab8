using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Context context = new Context();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.User.Add(new User()
            {
                Name = "Liza",
                Likes = 1733

            });
            context.User.Add(new User()
            {
                Name = "Moxe",
                Likes = 1234

            });
            context.User.Add(new User()
            {
                Name = "Ilya",
                Likes = 120

            });
            context.User.Add(new User()
            {
                Name = "Sveta",
                Likes = 2192

            });
            context.SaveChanges();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
