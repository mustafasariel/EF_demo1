using Demo3.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo3.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=AppData\soliddb.db");
        }
    }
}