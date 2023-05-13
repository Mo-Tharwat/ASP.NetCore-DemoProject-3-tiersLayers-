using Demo.DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Contexts
{
    public class MVCAppDbContext : IdentityDbContext<ApplicationUser>
    {
        //use Dependance Injection DbContext
        public MVCAppDbContext(DbContextOptions options):base(options)
        {
            
        }

        ///This is old way for connection database.
        ///protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        ///    => optionsBuilder.UseSqlServer("Server = .; Database = DB3Tiers; Trusted_Connection = true; MultipleActiveResultSets = true");
        ///
        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
}
