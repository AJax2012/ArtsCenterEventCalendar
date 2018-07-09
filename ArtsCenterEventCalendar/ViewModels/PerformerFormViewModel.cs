using System.Collections.Generic;
using ArtsCenterEventCalendar.Models;

namespace ArtsCenterEventCalendar.ViewModels
{
    public class PerformerFormViewModel
    {
        public IEnumerable<PerformerType> PerformerTypes { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<Topic> Topics { get; set; }
        public Performer Performer { get; set; }
    }
}