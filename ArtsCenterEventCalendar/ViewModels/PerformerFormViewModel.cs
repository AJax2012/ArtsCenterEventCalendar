using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ArtsCenterEventCalendar.Models;

namespace ArtsCenterEventCalendar.ViewModels
{
    public class PerformerFormViewModel
    {
        public IEnumerable<PerformerType> PerformerTypes { get; set; }
        public Performer Performer { get; set; }
    }
}