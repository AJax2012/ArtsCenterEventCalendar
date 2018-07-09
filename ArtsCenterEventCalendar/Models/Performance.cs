using System;
using System.ComponentModel.DataAnnotations;

namespace ArtsCenterEventCalendar.Models
{
    public class Performance
    {
        public int Id { get; set; }

        public int SeatsRemaining { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }
        
        [Display(Name = "Event Date and Time")]
        public DateTime EventDateTime { get; set; }

        public Performer Performer { get; set; }

        [Display(Name = "Performer")]
        public int PerformerId { get; set; }

        public virtual Venue Venue { get; set; }

        [Display(Name = "Venue")]
        public int VenueId { get; set; }
    }
}