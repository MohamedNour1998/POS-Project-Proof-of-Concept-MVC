using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoDemo.Models
{
    public class ITIEntity:IdentityDbContext<ApplicationUser>
    {
        public ITIEntity():base()
        {

        }
        public ITIEntity(DbContextOptions options):base(options)
        {
                
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server =.; database = ITIDemoDb; Integrated Security = true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
