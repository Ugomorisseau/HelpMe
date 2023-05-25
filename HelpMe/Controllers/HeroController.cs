using HelpMe.Domain.Models;
using HelpMe.Interface;
using Microsoft.AspNetCore.Mvc;

namespace HelpMe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        private readonly IHeroService _heroService;

        public HeroController(IHeroService heroService)
        {
            _heroService = heroService;
        }

        [HttpGet]
        public async Task<IActionResult> GetSuperHeroes()
        {
            try
            {
                var result = await _heroService.GetHeroes();
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetHeroById(int id)
        {
            try
            {
                var hero = await _heroService.GetHeroById(id);

                if (hero == null)
                {
                    return NotFound();
                }

                return Ok(hero);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateHero(Hero hero)
        {
            try
            {
                await _heroService.CreateHero(hero);
                return CreatedAtAction("GetHeroById", new { id = hero.Id }, hero);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ModifyHero(int id, Hero hero)
        {
            if (id != hero.Id)
            {
                return BadRequest();
            }

            try
            {
                await _heroService.ModifyHero(hero);
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHero(int id)
        {
            try
            {
                var hero = await _heroService.GetHeroById(id);
                if (hero == null)
                {
                    return NotFound();
                }

                await _heroService.DeleteHero(hero);

                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }
    }
}