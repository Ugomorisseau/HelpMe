using System.ComponentModel.DataAnnotations;

namespace HelpMe.Domain.Models;

public class UserAdmin
{
    [Key]
    public int Id { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public bool IsAdmin { get; set; }
}