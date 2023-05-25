using HelpMe.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace HelpMe.Infrastructure.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Incident> Incidents { get; set; }
        public DbSet<TypeIncident> TypeIncidents { get; set; }
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<HeroIncident> HeroIncidents { get; set; }
        public DbSet<TypeIncidentHero> TypeIncidentHeroes { get; set; }
    }
}