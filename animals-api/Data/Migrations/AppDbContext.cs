using animals_api.Animals.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace animals_api.Data.Migrations
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Animal> Animals {get; set; }
    }
}
