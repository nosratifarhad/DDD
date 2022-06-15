using ByeBikari.InfraEntityFrameWork.DataModels.Users;
using Microsoft.EntityFrameworkCore;

namespace ByeBikari.InfraEntityFrameWork
{
    public class ByeBikariReadContext : DbContext
    {
       public DbSet<User> Users { get; set; }
        public DbSet<Testsss> Tests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ByeBikariReadDB;Integrated Security=true");
        }

    }
}
