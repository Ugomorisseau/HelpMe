namespace HelpMe.Domain.Models
{
    public class Hero
    {
        public int Id { get; set; } // ID unique du Super Héros dans la base de données
        public string Name { get; set; } // Nom du Super Héros
        public double Latitude { get; set; } // Latitude de la position géographique du Super Héros
        public double Longitude { get; set; } // Longitude de la position géographique du Super Héros
        public string PhoneNumber { get; set; } // Numéro de téléphone du Super Héros
        public virtual ICollection<TypeIncidentHero>? TypeIncidentHero { get; set; } // Collection de références aux SuperHeroIncidentResources associés à ce Super Héros
        public virtual ICollection<HeroIncident>? HeroIncident { get; set; } // Collection de références aux SuperHeroIncidents associés à ce Super Héros
    }
}