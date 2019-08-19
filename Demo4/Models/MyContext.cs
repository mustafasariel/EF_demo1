using Demo4.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo4.Models
{
    public class MyContext : DbContext
    {
     

        public DbSet<Ogrenci> Ogrenci { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=AppData\solid.db");
        }
    }
}

