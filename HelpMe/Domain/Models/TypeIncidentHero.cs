namespace HelpMe.Domain.Models
{
    public class TypeIncidentHero
    {
        public int Id { get; set; } 
        public int HeroId { get; set; } 
        public int TypeIncidentId { get; set; } 
        public virtual Hero? Hero { get; set; } 
        public virtual TypeIncident? TypeIncident { get; set; } 
    }
}