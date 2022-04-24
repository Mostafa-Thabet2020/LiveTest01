using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LiveTestDomain.Infrastructure
{
    public class ApplicationDbContext:DbContext
    {
        public const string ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=LiveTest;Trusted_Connection=True";
       
        public DbSet<ApplicationSetting> settings { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Empolyee> empolyees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
