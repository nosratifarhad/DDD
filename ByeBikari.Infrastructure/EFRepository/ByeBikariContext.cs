using ByeBikari.Infrastructure.DataModel.Authentications;
using Microsoft.EntityFrameworkCore;

namespace ByeBikari.Infrastructure.EFRepository
{
    public class ByeBikariContext:DbContext
    {
        DbSet<PersonDTO> Authentication { get; set; }
    }
}
