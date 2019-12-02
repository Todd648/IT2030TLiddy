using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FinalProject.Models
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
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
    public class FinalProjectDB : DbContext
    {
        public FinalProjectDB() : base("name=MVCEventDB")
        {

        }
        public System.Data.Entity.DbSet<FinalProject.Models.Event> Events { get; set; }
        public System.Data.Entity.DbSet<FinalProject.Models.Organizer> Organizers { get; set; }

        public System.Data.Entity.DbSet<FinalProject.Models.Venue> Venues { get; set; }
        // public System.Data.Entity.DbSet<FinalProject.Models.Venue> Venues { get; set; }
    }
}