using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ArtsCenterEventCalendar.Models
{
    public class Performer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string TourName { get; set; }

        public bool IsActive { get; set; }

        public Genre Genre { get; set; }

        public int? GenreId { get; set; }

        public Topic Topic { get; set; }

        public int? TopicId { get; set; }
        
        public PerformerType PerformerType { get; set; }

        [Display(Name = "Performer Type")]
        public int PerformerTypeId { get; set; }

        public ICollection<Performance> Performances { get; set; }
    }
}