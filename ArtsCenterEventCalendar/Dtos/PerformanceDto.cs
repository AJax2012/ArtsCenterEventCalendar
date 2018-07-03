﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ArtsCenterEventCalendar.Models;

namespace ArtsCenterEventCalendar.Dtos
{
    public class PerformanceDto
    {
        public int Id { get; set; }

        public int SeatsRemaining { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public DateTime EventDateTime { get; set; }

        public int PerformerId { get; set; }

        public int VenueId { get; set; }
    }
}