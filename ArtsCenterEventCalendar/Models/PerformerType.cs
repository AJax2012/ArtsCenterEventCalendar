using System.Collections.Generic;

namespace ArtsCenterEventCalendar.Models
{
    public class PerformerType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Performer> Performers { get; set; }

        public PerformerType()
        {
            Performers = new List<Performer>();
        }
    }
}