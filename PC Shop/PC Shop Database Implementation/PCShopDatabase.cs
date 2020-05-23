using PC_Shop_Database_Implementation.Models;
using Microsoft.EntityFrameworkCore;

namespace PC_Shop_Database_Implementation
{
    public class PCShopDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-82A8HG1\SQLEXPRESS;
                Initial Catalog=PCShopDatabase;Integrated Security=True;
                MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Component> Components { set; get; }
        public virtual DbSet<Computer> Computers { set; get; }
        public virtual DbSet<ComputerComponent> ComputerComponents { set; get; }
        public virtual DbSet<Order> Orders { set; get; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<RequestComponent> RequestComponents { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<WarehouseComponent> WarehouseComponents { get; set; }
    }
}
