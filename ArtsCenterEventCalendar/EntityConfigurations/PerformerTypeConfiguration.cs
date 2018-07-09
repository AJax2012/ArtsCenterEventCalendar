using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ArtsCenterEventCalendar.Models;

namespace ArtsCenterEventCalendar.EntityConfigurations
{
    public class PerformerTypeConfiguration : EntityTypeConfiguration<PerformerType>
    {
        public PerformerTypeConfiguration()
        {
            HasIndex(p => p.Name)
                .IsUnique();

            Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}