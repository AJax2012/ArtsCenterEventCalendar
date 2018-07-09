using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using ArtsCenterEventCalendar.EntityConfigurations;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ArtsCenterEventCalendar.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Performance> Performances { get; set; }
        public virtual DbSet<PerformerType> PerformerTypes { get; set; }
        public virtual DbSet<Performer> Performers { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<Venue> Venues { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // ADD CONFIGURATIONS
            modelBuilder.Configurations.Add(new AddressConfiguration());
            modelBuilder.Configurations.Add(new GenreConfiguration());
            modelBuilder.Configurations.Add(new PerformanceConfiguration());
            modelBuilder.Configurations.Add(new PerformerConfiguration());
            modelBuilder.Configurations.Add(new PerformerTypeConfiguration());
            modelBuilder.Configurations.Add(new TopicConfiguration());
            modelBuilder.Configurations.Add(new VenueConfiguration());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}