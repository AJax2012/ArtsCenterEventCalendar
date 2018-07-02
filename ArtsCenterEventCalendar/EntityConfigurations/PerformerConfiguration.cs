using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using ArtsCenterEventCalendar.Models;

namespace ArtsCenterEventCalendar.EntityConfigurations
{
    public class PerformerConfiguration : EntityTypeConfiguration<Performer>
    {
        public PerformerConfiguration()
        {
            Property(p => p.Id)
                .HasDatabaseGeneratedOption(
                    DatabaseGeneratedOption.Identity);

            Property(p => p.Name)
                .IsRequired();

            HasRequired(p => p.PerformerType)
                .WithMany(p => p.Performers)
                .HasForeignKey(p => p.PerformerTypeId)
                .WillCascadeOnDelete(false);

            HasMany(p => p.Performances)
                .WithRequired(p => p.Performer)
                .HasForeignKey(p => p.PerformerId)
                .WillCascadeOnDelete(false);

//            Map<Musician>(p => p.Requires("PerformerTypeId").HasValue(1));
        }
    }
}