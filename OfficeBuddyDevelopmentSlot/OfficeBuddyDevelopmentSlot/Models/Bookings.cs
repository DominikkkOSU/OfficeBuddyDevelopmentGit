using System;

namespace Models
{
    public enum BookingStatus
    {
        Active = 0,
        Cancelled = 1
    }

    public class Booking
    {
        public int Id { get; set; }

        public int DeskId { get; set; }
        public Desk Desk { get; set; } = default!;

        public string UserId { get; set; } = default!;   // IdentityUser key is string
        public ApplicationUser User { get; set; } = default!;

        public DateTime StartUtc { get; set; }
        public DateTime EndUtc { get; set; }

        public BookingStatus Status { get; set; } = BookingStatus.Active;

        // Auditing / concurrency
        public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
        public DateTime? CancelledUtc { get; set; }
        public byte[] RowVersion { get; set; } = default!; // concurrency token
        public string? Notes { get; set; }

    }
}
