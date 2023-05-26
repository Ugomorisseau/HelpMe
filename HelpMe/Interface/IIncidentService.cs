using HelpMe.Domain.Models;

namespace HelpMe.Interface;

public interface IIncidentService
{
    Task<IEnumerable<Incident>> GetIncidents();
    Task<Incident> GetIncidentById(int id);
    Task CreateIncident(Incident incident);
    Task ModifyIncident(Incident incident);
    Task DeleteIncident(Incident incident);
    Task<TypeIncident> GetIncidentTypeById(int id);

}