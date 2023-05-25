using HelpMe.Domain.Models;
using HelpMe.Infrastructure.Persistence.Contexts;
using HelpMe.Interface;
using Microsoft.EntityFrameworkCore;

namespace HelpMe.Service
{
    public class HeroService : IHeroService
    {
        private readonly AppDbContext _context;

        public HeroService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Hero>> GetHeroes()
        {
            return await _context.Heroes.ToListAsync();
        }

        public async Task<Hero> GetHeroById(int id)
        {
            return await _context.Heroes.FindAsync(id);
        }

        public async Task CreateHero(Hero hero)
        {
            _context.Heroes.Add(hero);
            await _context.SaveChangesAsync();
        }

        public async Task ModifyHero(Hero hero)
        {
            _context.Entry(hero).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteHero(Hero hero)
        {
            _context.Heroes.Remove(hero);
            await _context.SaveChangesAsync();
        }
    }
}