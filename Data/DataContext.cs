using Inventory.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=G™KSEL\\SQLEXPRESS;initial catalog=InvenDB;integrated security=true;TrustServerCertificate=Yes");
        }

        public DbSet<InventoryItem> Inventories { get; set; }
    }
}
