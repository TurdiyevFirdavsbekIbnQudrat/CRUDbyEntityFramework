using Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCRUD.Data
{
    public class AppDbContext:DbContext
    {
        private readonly string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=Firdavs1;Database=CES2;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
        }
       public DbSet<Company> companies { get; set; }
       public DbSet<Employee> employees { get; set; }
       public DbSet<Staff> staffs { get; set; }
    }
}
