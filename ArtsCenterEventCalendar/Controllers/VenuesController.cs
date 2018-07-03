using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArtsCenterEventCalendar.Models;

namespace ArtsCenterEventCalendar.Controllers
{
    public class VenueController : Controller
    {
        private ApplicationDbContext _context;

        public VenueController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Venue
        public ActionResult Index()
        {
            var venues = _context.Venues
                .Include(v => v.Address)
                .ToList();

            return View(venues);
        }
    }
}