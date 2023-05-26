namespace HelpMe.Domain.Models
{
    public class TypeIncident
    {
        public int Id { get; set; } 
        public string Type { get; set; } 
        public virtual ICollection<TypeIncidentHero>? TypeIncidentHero { get; set; }  
        public virtual ICollection<Incident>? Incidents { get; set; } 
    }
}