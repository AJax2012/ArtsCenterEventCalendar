using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ArtsCenterEventCalendar.Models
{
    public class Venue
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "Number of Seats in Venue")]
        public int NumberOfSeats { get; set; }

        public Address Address { get; set; }

        [Display(Name = "Address")]
        public int AddressId { get; set; }

        public ICollection<Performance> Performances { get; set; }
    }
}