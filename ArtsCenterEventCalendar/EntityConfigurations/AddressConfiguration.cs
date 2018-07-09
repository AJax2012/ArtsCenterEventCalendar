using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ArtsCenterEventCalendar.Models;

namespace ArtsCenterEventCalendar.EntityConfigurations
{
    public class AddressConfiguration : EntityTypeConfiguration<Address>
    {
        public AddressConfiguration()
        {
            Property(a => a.City)
                .IsRequired()
                .HasMaxLength(20);

            Property(a => a.Id)
                .HasDatabaseGeneratedOption(
                    DatabaseGeneratedOption.Identity);

            Property(a => a.IsActive)
                .IsRequired();

            Property(a => a.State)
                .IsRequired()
                .HasMaxLength(2);

            Property(a => a.StreetAddress)
                .IsRequired()
                .HasMaxLength(50);

            Property(a => a.ZipCode)
                .IsRequired()
                .HasMaxLength(5);

            HasOptional(a => a.Venue)
                .WithRequired(v => v.Address)
                .WillCascadeOnDelete(false);
           }
    }
}