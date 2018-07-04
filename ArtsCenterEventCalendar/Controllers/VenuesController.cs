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
    public class VenuesController : Controller
    {
        private ApplicationDbContext _context;

        public VenuesController()
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

        public ActionResult New()
        {
            var addresses = _context.Addresses;

            var viewModel = new VenueFormViewModel()
            {
                Venue = new Venue(),
                Addresses = addresses
            };

            return View("VenueForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var venue = _context.Venues.SingleOrDefault(p => p.Id == id);
            var addresses = _context.Addresses.ToList();

            if (venue == null)
                return HttpNotFound();

            var viewModel = new VenueFormViewModel
            {
                Venue = venue,
                Addresses = addresses
            };

            return View("VenueForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Venue venue)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new VenueFormViewModel
                {
                    Venue = venue,
                    Addresses = _context.Addresses.ToList()
                };

                return View("VenueForm", viewModel);
            }

            if (venue.Id == 0)
                _context.Venues.Add(venue);
            else
            {
                var venueInDb = _context.Venues.Single(v => v.Id == venue.Id);
                var addressInDb = _context.Addresses.Single(a => a.Id == venue.AddressId);

                venueInDb.Id = venue.Id;
                venueInDb.Name = venue.Name;
                venueInDb.Capacity = venue.Capacity;
                venueInDb.AddressId = venue.AddressId;
                venueInDb.Performances = venue.Performances;
                addressInDb.City = venue.Address.City;
                addressInDb.State = venue.Address.State;
                addressInDb.StreetAddress = venue.Address.StreetAddress;
                addressInDb.ZipCode = venue.Address.ZipCode;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Venues");
        }
    }
}