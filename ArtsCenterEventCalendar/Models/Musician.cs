using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArtsCenterEventCalendar.Models
{
    public class Musician : Performer
    {
        public string TourName { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public new int PerformerTypeId { get; set; } = 1;
    }
}