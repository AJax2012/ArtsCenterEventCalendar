using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArtsCenterEventCalendar.Models;
using ArtsCenterEventCalendar.ViewModels;
using AutoMapper;

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
                .Include(p => p.Genre)
                .Include(p => p.Topic)
                .ToList();

            return View(performers);
        }

        public ActionResult New()
        {
            var genres = _context.Genres;
            var topics = _context.Topics;

            var viewModel = new PerformerFormViewModel
            {
                Performer = new Performer(),
                Genres = genres,
                Topics = topics
            };

            return View("PerformerForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var performer = _context.Performers.SingleOrDefault(p => p.Id == id);

            if (performer == null)
                return HttpNotFound();

            var viewModel = new PerformerFormViewModel
            {
                Performer = performer,
                PerformerTypes = _context.PerformerTypes.ToList(),
                Genres = _context.Genres.ToList(),
                Topics = _context.Topics.ToList()
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
                    Genres = _context.Genres.ToList(),
                    Topics = _context.Topics.ToList()
                };

                return View("PerformerForm", viewModel);
            }

            if (performer.Id == 0)
                _context.Performers.Add(performer);
            else
            {
                var performerInDb = _context.Performers.Single(p => p.Id == performer.Id);

//                AutoMapper.Mapper.Map(performer, performerInDb);
                performerInDb.Id = performer.Id;
                performerInDb.Name = performer.Name;
                performerInDb.Description = performer.Description;
                performerInDb.TourName = performer.TourName;
                performerInDb.GenreId = performer.GenreId;
                performerInDb.TopicId = performer.TopicId;
                performerInDb.PerformerTypeId = performer.PerformerTypeId;
                performerInDb.Performances = performer.Performances;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Performers");
        }

        
    }
}