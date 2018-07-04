using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ArtsCenterEventCalendar.Models
{
    public class Venue
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public Address Address { get; set; }

        [Display(Name = "Address")]
        public int AddressId { get; set; }

        public ICollection<Performance> Performances { get; set; }
    }
}