using Microsoft.AspNetCore;

namespace VehiclePriceCalculator.WebApp
{

    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
                    WebHost.CreateDefaultBuilder(args)
                        .UseStartup<Startup>();

    }
}
