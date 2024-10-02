using EpitmenyadoWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace EpitmenyadoWebApp.Data
{
    public class EpitmenyadoDbContext : DbContext
    {
        public EpitmenyadoDbContext(DbContextOptions<EpitmenyadoDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Epitmeny> Epitmenyek { get; set; }
    }
}
