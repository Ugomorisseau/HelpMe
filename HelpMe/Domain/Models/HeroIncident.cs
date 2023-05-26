namespace HelpMe.Domain.Models
{
    public class HeroIncident
    {
        public int Id { get; set; } 
        public int HeroId { get; set; } 
        public int IncidentId { get; set; } 
        public virtual Hero? Hero { get; set; } 
        public virtual Incident? Incident { get; set; } 
    }
}