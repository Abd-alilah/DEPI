using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeDataApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDataApp
{
    public class AppDbContext : DbContext
    {
        const string ConnectionString = "Data Source=.;Initial Catalog=EmployeeAppDB;Integrated Security=True;Trust Server Certificate=True";
        public AppDbContext()
        {
            
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        // Tables --> DbSet<>
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(ConnectionString);
        


}
}


