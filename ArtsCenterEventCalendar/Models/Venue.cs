using System.Collections.Generic;

namespace ArtsCenterEventCalendar.Models
{
    public class Venue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfSeats { get; set; }
        public Address Address { get; set; }
        public int AddressId { get; set; }
        public ICollection<Performance> Performances { get; set; }

        public Venue()
        {
            Performances = new List<Performance>();
        }
    }
}