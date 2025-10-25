using System.ComponentModel.DataAnnotations;

namespace OfficeBuddyDevelopmentGit.Models;

public class Desk
{
    public int DeskID { get; set; }

    [Required]
    [StringLength(50)]
    public string Cislo_stolu { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string misto { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;

    
    public ICollection<Booking>? dochazka { get; set; }
}
