using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArtsCenterEventCalendar.Models
{
    public class Performance
    {
        public int Id { get; set; }
        public int SeatsRemaining { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime EventDateTime { get; set; }
        public Performer Performer { get; set; }
        public int PerformerId { get; set; }
        public virtual Venue Venue { get; set; }
        public int VenueId { get; set; }
    }
}