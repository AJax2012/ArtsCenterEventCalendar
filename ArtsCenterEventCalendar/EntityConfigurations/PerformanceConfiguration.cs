using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using ArtsCenterEventCalendar.Models;

namespace ArtsCenterEventCalendar.EntityConfigurations
{
    public class PerformanceConfiguration : EntityTypeConfiguration<Performance>
    {
        public PerformanceConfiguration()
        {
            Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Price)
                .HasPrecision(6, 2);
            
            HasRequired(p => p.Venue)
                .WithMany(v => v.Performances)
                .HasForeignKey(p => p.VenueId)
                .WillCascadeOnDelete(false);
        }
    }
}