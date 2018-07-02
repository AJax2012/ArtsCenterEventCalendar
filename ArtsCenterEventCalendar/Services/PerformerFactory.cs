using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ArtsCenterEventCalendar.Models;

namespace ArtsCenterEventCalendar.Services
{
    public class PerformerFactory : IPerformerFactory
    {
        public void SetPerformerType(Performer targetPerformer)
        {
            if (targetPerformer is Musician)
                targetPerformer.PerformerTypeId = 1;
        }
    }
}