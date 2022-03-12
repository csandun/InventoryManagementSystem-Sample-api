using InventoryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.DataAccess
{
    public class InventorySystemDbContext : DbContext
    {
        public InventorySystemDbContext(DbContextOptions<InventorySystemDbContext> options) : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
