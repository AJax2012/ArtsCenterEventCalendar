using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ArtsCenterEventCalendar.Models;

namespace ArtsCenterEventCalendar.Dtos
{
    public class PerformerDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string TourName { get; set; }

        public string Genre { get; set; }

        public string Topic { get; set; }

        public int PerformerTypeId { get; set; }

    }
}