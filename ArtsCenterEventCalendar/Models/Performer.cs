using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArtsCenterEventCalendar.Models
{
    public abstract class Performer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public PerformerType PerformerType { get; set; }

        [Display(Name = "Performer Type")]
        public int PerformerTypeId { get; set; }

        public ICollection<Performance> Performances { get; set; }
    }
}