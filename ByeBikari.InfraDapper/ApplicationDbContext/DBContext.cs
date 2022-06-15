using ByeBikari.InfraDapper.Models.JobSeekerAuthentications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByeBikari.InfraDapper.ApplicationDbContext
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<JobSeekerAuthentication> JobSeekerAuthentication { get; set; }
        //public DbSet<Director> Directors { get; set; }
    }
}
