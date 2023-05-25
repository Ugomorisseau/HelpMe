namespace HelpMe.Domain.Models
{
    public class TypeIncident
    {
        public int Id { get; set; } // ID unique de la ressource d'incident dans la base de données
        public string Type { get; set; } // Type de la ressource d'incident
        public virtual ICollection<TypeIncidentHero>? TypeIncidentHero { get; set; } // Collection de références aux SuperHeroIncidentResources associés à cette ressource d'incident
        public virtual ICollection<Incident>? Incidents { get; set; } // Collection de références aux Incidents associés à cette ressource d'incident
    }
}