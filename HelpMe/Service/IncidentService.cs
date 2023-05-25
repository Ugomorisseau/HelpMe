using HelpMe.Domain.Models;
using HelpMe.Infrastructure.Persistence.Contexts;
using HelpMe.Interface;
using Microsoft.EntityFrameworkCore;

namespace HelpMe.Service
{
    public class IncidentService : IIncidentService
    {
        private readonly AppDbContext _context;

        public IncidentService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Incident>> GetIncidents()
        {
            return await _context.Incidents.ToListAsync();
        }

        public async Task<Incident> GetIncidentById(int id)
        {
            return await _context.Incidents.FindAsync(id);
        }

        public async Task CreateIncident(Incident incident)
        {
            _context.Incidents.Add(incident);
            await _context.SaveChangesAsync();
        }

        public async Task ModifyIncident(Incident incident)
        {
            _context.Entry(incident).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteIncident(Incident incident)
        {
            _context.Incidents.Remove(incident);
            await _context.SaveChangesAsync();
        }
    }
}