using System.Collections.Generic;

namespace ArtsCenterEventCalendar.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Performer> Performers { get; set; }
    }
}