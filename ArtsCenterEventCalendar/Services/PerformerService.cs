using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ArtsCenterEventCalendar.Models;

namespace ArtsCenterEventCalendar.Services
{
    public class PerformerService
    {
        private readonly IPerformerFactory _factory;

        public PerformerService()
        {
            _factory = new PerformerFactory();
        }

        public Performer CreateMusician()
        {
            var musician = new Musician();
            _factory.SetPerformerType(musician);
            return musician;
        }
    }
}