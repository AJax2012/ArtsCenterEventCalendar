using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ArtsCenterEventCalendar.Models;

namespace ArtsCenterEventCalendar.EntityConfigurations
{
    public class VenueConfiguration : EntityTypeConfiguration<Venue>
    {
        public VenueConfiguration()
        {
            HasIndex(v => v.Name)
                .IsUnique();

            Property(v => v.Id)
                .HasDatabaseGeneratedOption(
                    DatabaseGeneratedOption.Identity);

            Property(v => v.IsActive)
                .IsRequired();

            Property(v => v.Name)
                .IsRequired()
                .HasMaxLength(100);

            HasRequired(v => v.Address)
                .WithOptional(a => a.Venue)
                .WillCascadeOnDelete(false);
            
            HasMany(v => v.Performances)
                .WithRequired(p => p.Venue)
                .HasForeignKey(v => v.VenueId)
                .WillCascadeOnDelete(false);
        }
    }
}