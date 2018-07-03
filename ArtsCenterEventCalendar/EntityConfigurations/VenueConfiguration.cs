using System.Data.Entity.ModelConfiguration;
using ArtsCenterEventCalendar.Models;

namespace ArtsCenterEventCalendar.EntityConfigurations
{
    public class VenueConfiguration : EntityTypeConfiguration<Venue>
    {
        public VenueConfiguration()
        {
            Property(v => v.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}