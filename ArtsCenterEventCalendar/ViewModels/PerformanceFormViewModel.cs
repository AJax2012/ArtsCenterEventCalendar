using System.Collections.Generic;
using ArtsCenterEventCalendar.Dtos;
using ArtsCenterEventCalendar.Models;

namespace ArtsCenterEventCalendar.ViewModels
{
    public class PerformanceFormViewModel
    {
        public IEnumerable<Performer> Performers { get; set; }
        public IEnumerable<Venue> Venues { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<Topic> Topics { get; set; }
        public Performance Performance { get; set; }
        public PerformanceDto PerformanceDto { get; set; }
    }
}