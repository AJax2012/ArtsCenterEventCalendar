using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ArtsCenterEventCalendar.Models;

namespace ArtsCenterEventCalendar.Dtos
{
    public class VenueDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int AddressId { get; set; }

        public ICollection<Performance> Performances { get; set; }
    }
}