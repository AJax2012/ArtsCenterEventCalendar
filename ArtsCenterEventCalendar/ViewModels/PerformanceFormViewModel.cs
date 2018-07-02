using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ArtsCenterEventCalendar.Models;

namespace ArtsCenterEventCalendar.ViewModels
{
    public class PerformanceFormViewModel
    {
        public IEnumerable<Performer> Performers { get; set; }
        public IEnumerable<Venue> Venues { get; set; }
        public Performance Performance { get; set; }
    }
}