using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArtsCenterEventCalendar.Models;
using ArtsCenterEventCalendar.ViewModels;

namespace ArtsCenterEventCalendar.Controllers
{
    public class PerformerController : Controller
    {
        private ApplicationDbContext _context;

        public PerformerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Performer
        public ActionResult Index()
        {
            var performers = _context.Performers
                .Include(p => p.PerformerType)
                .ToList();

            return View(performers);
        }

        // POST: Performer
        
    }
}