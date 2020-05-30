using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using PC_Shop_Business_Logic.View_Models;

namespace SupplierView
{
    public class Program
    {
        public static SupplierViewModel Supplier { get; set; }

        public static void Main(string[] args)
        {
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
