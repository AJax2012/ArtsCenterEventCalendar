using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ArtsCenterEventCalendar.Models;

namespace ArtsCenterEventCalendar.EntityConfigurations
{
    public class GenreConfiguration : EntityTypeConfiguration<Genre>
    {
        public GenreConfiguration()
        {
            HasIndex(g => g.Name)
                .IsUnique();

            Property(g => g.Id)
                .HasDatabaseGeneratedOption(
                    DatabaseGeneratedOption.Identity);

            Property(g => g.Name)
                .IsRequired()
                .HasMaxLength(50);

            HasMany(g => g.Performers)
                .WithOptional(p => p.Genre)
                .WillCascadeOnDelete(false);
        }
    }
}