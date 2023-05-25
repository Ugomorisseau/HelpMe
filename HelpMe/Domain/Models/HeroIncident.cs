namespace HelpMe.Domain.Models
{
    public class HeroIncident
    {
        public int Id { get; set; } // ID unique de la relation SuperHeroIncident dans la base de données
        public int HeroId { get; set; } // ID du Super Héros associé à cette relation
        public int IncidentId { get; set; } // ID de l'incident associé à cette relation
        public virtual Hero? Hero { get; set; } // Référence au Super Héros associé à cette relation
        public virtual Incident? Incident { get; set; } // Référence à l'incident associé à cette relation
    }
}