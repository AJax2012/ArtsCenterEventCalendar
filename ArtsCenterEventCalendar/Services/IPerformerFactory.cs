using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtsCenterEventCalendar.Models;

namespace ArtsCenterEventCalendar.Services
{
    interface IPerformerFactory
    {
        void SetPerformerType (Performer targetPerformer);
    }
}
