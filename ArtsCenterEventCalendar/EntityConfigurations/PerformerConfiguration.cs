using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ArtsCenterEventCalendar.Models;

namespace ArtsCenterEventCalendar.EntityConfigurations
{
    public class PerformerConfiguration : EntityTypeConfiguration<Performer>
    {
        public PerformerConfiguration()
        {
            HasIndex(p => p.Name)
                .IsUnique();

            Property(p => p.Id)
                .HasDatabaseGeneratedOption(
                    DatabaseGeneratedOption.Identity);

            Property(p => p.IsActive)
                .IsRequired();

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            HasRequired(p => p.PerformerType)
                .WithMany(p => p.Performers)
                .HasForeignKey(p => p.PerformerTypeId)
                .WillCascadeOnDelete(false);

            HasMany(p => p.Performances)
                .WithRequired(p => p.Performer)
                .HasForeignKey(p => p.PerformerId)
                .WillCascadeOnDelete(false);
        }
    }
}