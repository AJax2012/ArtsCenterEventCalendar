﻿using System.Collections.Generic;

namespace ArtsCenterEventCalendar.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Performer> Performers { get; set; }
    }
}