using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PC_Shop_Business_Logic.View_Models;

namespace SupplierView
{
    public class Program
    {
        public static SupplierViewModel Supplier { get; set; }
        //public static List<RequestViewModel> Requests { get; set; }
        //public static List<WarehouseViewModel> Warehouses { get; set; }

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
