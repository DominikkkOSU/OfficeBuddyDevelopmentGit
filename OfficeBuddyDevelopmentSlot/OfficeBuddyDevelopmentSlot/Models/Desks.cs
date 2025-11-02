using System;
using System.Collections.Generic;

namespace Models
{
    public class Desk
    {
        public int Id { get; set; }

        // A human-friendly code for the map/label (e.g., "A12")
        public string Code { get; set; } = default!;
        public string? Name { get; set; }
        public int Capacity { get; set; } = 1;
        public bool IsActive { get; set; } = true;

        // Optional: to render clickable plan
        public string? Area { get; set; }      // e.g., “2nd floor”
        public int? X { get; set; }            // pixel coords if you have a floor plan
        public int? Y { get; set; }


        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
