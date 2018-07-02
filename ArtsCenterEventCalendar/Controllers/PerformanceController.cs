using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.Expressions;
using ArtsCenterEventCalendar.Models;
using Microsoft.Ajax.Utilities;

namespace ArtsCenterEventCalendar.Controllers
{
    public class PerformanceController : Controller
    {
        private ApplicationDbContext _context;

        public PerformanceController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        
        // GET: Performance
        public ActionResult Index()
        {
            var performances = _context.Performances
                .Include(p => p.Performer)
                .Include(p => p.Performer.PerformerType)
                .Include(p => p.Venue)
                .Include(p => p.Venue.Address)
                .ToList();

            return View(performances);
        }
    }
}