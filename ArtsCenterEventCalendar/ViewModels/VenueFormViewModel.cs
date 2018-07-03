using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ArtsCenterEventCalendar.Models;

namespace ArtsCenterEventCalendar.ViewModels
{
    public class VenueFormViewModel
    {
        public IEnumerable<Address> Addresses { get; set; }
        public Venue Venue { get; set; }
    }
}