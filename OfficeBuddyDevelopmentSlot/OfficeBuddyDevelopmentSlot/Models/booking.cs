using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeBuddyDevelopmentGit.Models;

public class Booking
{
    public int ID { get; set; }

    [Required]
    public int UserId { get; set; }

    [Required]
    public int DeskId { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime Date { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public bool IsCancelled { get; set; } = false;

    // Navigation properties
    public User? User { get; set; }
    public Desk? Desk { get; set; }
}
