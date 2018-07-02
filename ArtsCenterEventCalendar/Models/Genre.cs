using System.Collections.Generic;

namespace ArtsCenterEventCalendar.Models
{
    public sealed class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Musician> Musicians { get; set; }

        public Genre()
        {
            Musicians = new List<Musician>();
        }
    }
}