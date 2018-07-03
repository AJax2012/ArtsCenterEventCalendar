using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using ArtsCenterEventCalendar.Models;

namespace ArtsCenterEventCalendar.EntityConfigurations
{
    public class TopicConfiguration : EntityTypeConfiguration<Topic>
    {
        public TopicConfiguration()
        {
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(20);

            HasMany(t => t.Performers)
                .WithOptional(p => p.Topic);
        }
    }
}