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
    public class PerformersController : Controller
    {
        private ApplicationDbContext _context;

        public PerformersController()
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

        public ActionResult Edit(int id)
        {
            var performer = _context.Performers.SingleOrDefault(p => p.Id == id);
            var performerTypes = _context.PerformerTypes.ToList();

            if (performer == null)
                return HttpNotFound();

            var viewModel = new PerformerFormViewModel
            {
                Performer = performer,
                PerformerTypes = performerTypes,
            };

            return View("PerformerForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Performer performer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new PerformerFormViewModel
                {
                    Performer = performer,
                    PerformerTypes = _context.PerformerTypes.ToList(),
                };

                return View("PerformerForm", viewModel);
            }

            if (performer.Id == 0)
                _context.Performers.Add(performer);
            else
            {
                var performerInDb = _context.Performers.Single(p => p.Id == performer.Id);

                performerInDb.Description = performerInDb.Description;
                performerInDb.Genre = performer.Genre;
                performerInDb.Name = performer.Name;
                performerInDb.Performances = performer.Performances;
                performerInDb.PerformerType = performerInDb.PerformerType;
                performerInDb.Topic = performer.Topic;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Performers");
        }

        
    }
}