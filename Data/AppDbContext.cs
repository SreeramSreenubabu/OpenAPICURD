using Microsoft.EntityFrameworkCore;
using ApiProject.Models;

namespace ApiProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        { optionsBuilder.UseSqlServer("Server=HP;Database=CRMdb;Integrated Security=True;TrustServerCertificate=yes;"); }  

        public DbSet<Item> Items { get; set; }
    }
}
