using HelpMe.Domain.Models;
using HelpMe.Interface;
using Microsoft.AspNetCore.Mvc;

namespace HelpMe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidentController : ControllerBase
    {
        private readonly IIncidentService _incidentService;

        public IncidentController(IIncidentService incidentService)
        {
            _incidentService = incidentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetIncidents()
        {
            try
            {
                var result = await _incidentService.GetIncidents();
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetIncidentById(int id)
        {
            try
            {
                var incident = await _incidentService.GetIncidentById(id);

                if (incident == null)
                {
                    return NotFound();
                }

                return Ok(incident);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateIncident(Incident incident)
        {
            try
            {
                await _incidentService.CreateIncident(incident);
                return CreatedAtAction("GetIncidentById", new { id = incident.Id }, incident);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ModifyIncident(int id, Incident incident)
        {
            if (id != incident.Id)
            {
                return BadRequest();
            }

            try
            {
                await _incidentService.ModifyIncident(incident);
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIncident(int id)
        {
            try
            {
                var incident = await _incidentService.GetIncidentById(id);
                if (incident == null)
                {
                    return NotFound();
                }

                await _incidentService.DeleteIncident(incident);

                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }
    }
}