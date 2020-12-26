using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //only called during first time, during worker process initialiation.At subsequent requests it wont be called
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
