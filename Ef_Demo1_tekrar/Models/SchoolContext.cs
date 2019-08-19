using Ef_Demo1_tekrar.Enitities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ef_Demo1_tekrar.Models
{
    public class SchoolContext : DbContext
    {

        public DbSet<Student> Students { get; set; }
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }
    }
}