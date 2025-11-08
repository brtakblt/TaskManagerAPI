using ENTITY;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        
        }

       

        public DbSet<Commet> commets { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<Assignment> assignments { get; set; }
        public DbSet<User> users { get; set; }

   
    }
}
