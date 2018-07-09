using System.Collections.Generic;
using ArtsCenterEventCalendar.Models;

namespace ArtsCenterEventCalendar.ViewModels
{
    public class VenueFormViewModel
    {
        public IEnumerable<Address> Addresses { get; set; }
        public Venue Venue { get; set; }

        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}