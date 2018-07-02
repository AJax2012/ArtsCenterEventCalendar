using System.Collections.Generic;
using ArtsCenterEventCalendar.Models;
using ArtsCenterEventCalendar.Services;

namespace ArtsCenterEventCalendar.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ArtsCenterEventCalendar.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ArtsCenterEventCalendar.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            
//            context.Addresses.AddOrUpdate(a => a.Id,
//                new Address() { StreetAddress = "18300 W Alameda Pkwy", City = "Morrison", State = "CO", ZipCode = "80465"},
//                new Address() { StreetAddress = "1000 Chopper Cir", City = "Denver", State = "CO", ZipCode = "80204" },
//                new Address() { StreetAddress = "20000 Pikes Peak Avenue", City = "Parker", State = "CO", ZipCode = "80138" },
//                new Address() { StreetAddress = "10075 Commons St", City = "Lone Tree", State = "CO", ZipCode = "80124" }
//                );
//
//            context.Venues.AddOrUpdate(v => v.Id,
//                new Venue() { Name = "Red Rocks", NumberOfSeats = 5000, AddressId = 1 },
//                new Venue() { Name = "Pepsi Center", NumberOfSeats = 3000, AddressId = 2 },
//                new Venue() { Name = "Parker Arts, Culture & Events Center (PACE Center)", NumberOfSeats = 550, AddressId = 3 },
//                new Venue() { Name = "Lone Tree Arts Center", NumberOfSeats = 600, AddressId = 4 }
//            );
//
//            context.PerformanceTypes.AddOrUpdate(p => p.Id,
//                new PerformerType() { Name = "Music" },
//                new PerformerType() { Name = "Comedy" },
//                new PerformerType() { Name = "Theater" },
//                new PerformerType() { Name = "Muiscal Theater" },
//                new PerformerType() { Name = "Motivational Speaker" },
//                new PerformerType() { Name = "Pannel" }
//                );
//
//            context.Genres.AddOrUpdate(g => g.Id,
//                new Genre() { Name = "Classical (Orchestra)" },
//                new Genre() { Name = "Classical (Solo)" },
//                new Genre() { Name = "Classic Rock" },
//                new Genre() { Name = "Alternative Rock" },
//                new Genre() { Name = "Hard Rock" },
//                new Genre() { Name = "Rock & Roll" },
//                new Genre() { Name = "Metal" },
//                new Genre() { Name = "Heavy Metal" },
//                new Genre() { Name = "Blues" },
//                new Genre() { Name = "Jazz" }
//                );
//
//            context.Performers.AddOrUpdate(p => p.Id,
//                new Musician() { Name = "Yo-Yo Ma", PerformerTypeId = 1, Description = "Famous Cellist", GenreId = 2, TourName = "Silk Road Project" },
//                new Musician() { Name = "New York Philharmonic", PerformerTypeId = 1, Description = "Famous Orchestra", GenreId = 1, TourName = "Americana" },
//                new Musician() { Name = "AC/DC", PerformerTypeId = 1, Description = "Famous Band", GenreId = 3, TourName = "Back from the Dead" },
//                new Musician() { Name = "Kelly Clarkson", PerformerTypeId = 1, Description = "Famous Singer", GenreId = 3, TourName = "Meaning of Life" },
//                new Musician() { Name = "Sonny Rollins", PerformerTypeId = 1, Description = "Famous Saxiphonist", GenreId = 3, TourName = "Saxin\' it Up!" }
//                );
//
//            context.Performances.AddOrUpdate(p => p.Id,
//                new Performance() { EventDateTime = new DateTime(2018, 07, 11, 18, 30, 00), Price = 70, Description = "Fun Times", VenueId = 1, SeatsRemaining = 3000, PerformerId = 1 },
//                new Performance() { EventDateTime = new DateTime(2018, 07, 10, 19, 30, 00), Price = 80, Description = "Fun Times", VenueId = 2, SeatsRemaining = 3000, PerformerId = 2 },
//                new Performance() { EventDateTime = new DateTime(2018, 07, 13, 19, 00, 00), Price = 60, Description = "Fun Times", VenueId = 3, SeatsRemaining = 3000, PerformerId = 3 },
//                new Performance() { EventDateTime = new DateTime(2018, 07, 18, 18, 45, 00), Price = 65, Description = "Fun Times", VenueId = 4, SeatsRemaining = 3000, PerformerId = 4 },
//                new Performance() { EventDateTime = new DateTime(2018, 07, 09, 19, 30, 00), Price = 75, Description = "Fun Times", VenueId = 1, SeatsRemaining = 3000, PerformerId = 5 },
//                new Performance() { EventDateTime = new DateTime(2018, 07, 05, 18, 30, 00), Price = 20, Description = "Fun Times", VenueId = 2, SeatsRemaining = 3000, PerformerId = 1 },
//                new Performance() { EventDateTime = new DateTime(2018, 07, 30, 20, 00, 00), Price = 100, Description = "Fun Times", VenueId = 3, SeatsRemaining = 3000, PerformerId = 2 }
//                );
        }
    }
}
