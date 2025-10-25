using System.ComponentModel.DataAnnotations;

namespace OfficeBuddyDevelopmentGit.Models;

public class User
{

    [required]
    [StringLengh(100)]
    public int Uzivatelske_cislo {get; set; }

    [required]
    [StringLengh(100)]
    public string Cele_jmeno {get; set; } = string.Empty

    [required]
    [EmailAdress]
    public string email {get; set; } = string.Empty

    [StringLengh(50)]
    public string? Department {get; set; }

    public ICollection<Booking>? dochazka { get; set; }
    
}