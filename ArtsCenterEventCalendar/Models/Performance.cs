using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Display(Name = "Event Date and Time")]
        public DateTime EventDateTime { get; set; }

        public Performer Performer { get; set; }

        public int PerformerId { get; set; }

        public virtual Venue Venue { get; set; }

        public int VenueId { get; set; }
    }
}