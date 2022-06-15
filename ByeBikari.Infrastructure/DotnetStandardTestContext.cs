using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByeBikari.Infrastructure
{
    class DotnetStandardTestContext : DbContext
    {
        public DbSet<UserTest> UserTests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DotnetStandardTestDB;Integrated Security=true");
        }

    }

}
