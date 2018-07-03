using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArtsCenterEventCalendar.Models
{
    public class Musician : Performer
    {
        public string TourName { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        public new int PerformerTypeId { get; set; } = 1;
    }
}