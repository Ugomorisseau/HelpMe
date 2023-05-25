namespace HelpMe.Domain.Models
{
    public class TypeIncidentHero
    {
        public int Id { get; set; } // ID unique de la relation SuperHeroIncidentResource dans la base de données
        public int HeroId { get; set; } // ID du Super Héros associé à cette relation
        public int TypeIncidentId { get; set; } // ID de la ressource d'incident associée à cette relation
        public virtual Hero? Hero { get; set; } // Référence au Super Héros associé à cette relation
        public virtual TypeIncident? TypeIncident { get; set; } // Référence à la ressource d'incident associée à cette relation
    }
}