using System.ComponentModel.DataAnnotations;

namespace OfficeBuddyDevelopmentGit.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Cele_jmeno { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string email { get; set; } = string.Empty;

        public string? Department { get; set; }

        [Required]
        public string AzureAdId { get; set; } = string.Empty; 

        public ICollection<Booking>? dochazka { get; set; }
    }
}