using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTests
{
    internal class ApplicationCotext : DbContext
    {
        public DbSet<Users> Users => Set<Users>();
        public ApplicationCotext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=myDB.db");
        }
    }
}
