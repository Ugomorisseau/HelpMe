namespace HelpMe.Domain.Models
{
    public class Incident
    {
        public int Id { get; set; } 
        public int TypeIncidentId { get; set; } 
        public string Ville { get; set; }
        public double Latitude { get; set; } 
        public double Longitude { get; set; } 
        public bool IsResolved { get; set; } 

        public virtual TypeIncident?
            TypeIncident { get; set; } 

        public virtual ICollection<HeroIncident>?
            HeroIncident { get; set; } 
    }
}