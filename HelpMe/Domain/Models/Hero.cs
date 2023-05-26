namespace HelpMe.Domain.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public virtual ICollection<TypeIncidentHero>? TypeIncidentHero { get; set; }
        public virtual ICollection<HeroIncident>? HeroIncident { get; set; }
    }

    public class LoginModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }

    public class HeroViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public string PhoneNumber { get; set; }
        
        public string Password { get; set; }

        public virtual ICollection<TypeIncidentHero>? TypeIncidentHero { get; set; }
        public virtual ICollection<HeroIncident>? HeroIncident { get; set; }

        public HeroViewModel(Hero hero)
        {
            Id = hero.Id;
            Name = hero.Name;
            Latitude = hero.Latitude;
            Longitude = hero.Longitude;
            PhoneNumber = hero.PhoneNumber;
            Password = hero.Password;
            HeroIncident = hero.HeroIncident;
            TypeIncidentHero = hero.TypeIncidentHero;
        }
    }
}