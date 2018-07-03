using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.Expressions;
using ArtsCenterEventCalendar.Models;
using ArtsCenterEventCalendar.ViewModels;
using AutoMapper;
using Microsoft.Ajax.Utilities;

namespace ArtsCenterEventCalendar.Controllers
{
    public class PerformancesController : Controller
    {
        private ApplicationDbContext _context;

        public PerformancesController()
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
        
        public ActionResult New()
        {
            var performers = _context.Performers.ToList();
            var venues = _context.Venues.ToList();

            var viewModel = new PerformanceFormViewModel
            {
                Performance = new Performance()
                {
                    EventDateTime = DateTime.Today.AddHours(19).AddMinutes(30)
                },

                Performers = performers,
                Venues = venues
            };

            return View("PerformanceForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var performance = _context.Performances.SingleOrDefault(p => p.Id == id);

            if (performance == null)
                return HttpNotFound();

            var viewModel = new PerformanceFormViewModel
            {
                Performance = performance,
                Performers = _context.Performers.ToList(),
                Venues = _context.Venues.ToList()
            };

            return View("PerformanceForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Performance performance)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new PerformanceFormViewModel
                {
                    Performance = performance,
                    Performers = _context.Performers.ToList(),
                    Venues = _context.Venues.ToList()
                };

                return View("PerformanceForm", viewModel);
            }

            if (performance.Id == 0)
            {
                performance.SeatsRemaining = performance.Venue.NumberOfSeats;
                _context.Performances.Add(performance);
            }
            else
            {
                var performanceInDb = _context.Performances.Single(p => p.Id == performance.Id);

//                Mapper.Map(performance, performanceInDb); - getting exception for _wrapper?
                performanceInDb.PerformerId = performance.PerformerId;
                performanceInDb.VenueId = performance.VenueId;
                performanceInDb.EventDateTime = performance.EventDateTime;
                performanceInDb.Price = performance.Price;
                performanceInDb.Description = performance.Description;
            }
            
            _context.SaveChanges();

            return RedirectToAction("Index", "Performances");
        }
    }
}