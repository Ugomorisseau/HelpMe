using HelpMe.Domain.Models;

namespace HelpMe.Interface;

public interface IHeroService
{
    Task<IEnumerable<Hero>> GetHeroes();
    Task<Hero> GetHeroById(int id);
    Task CreateHero(Hero hero);
    Task ModifyHero(Hero hero);
    Task DeleteHero(Hero hero);
    Hero Auth(string name, string password);

}