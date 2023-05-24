using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace InventoryService.Models
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {

        }
        public virtual DbSet<Products> Products { get;set;}
        public virtual DbSet<UserInfo> UserInfo { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=STAMENS-PC\\SQLEXPRESS;database=Inventory; Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}
