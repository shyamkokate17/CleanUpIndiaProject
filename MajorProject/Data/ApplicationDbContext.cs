
using CleanUpIndia.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CleanUpIndia.Data
{
    public class ApplicationDbContext 
        : IdentityDbContext                      // DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> Options) 
            : base(Options)
        {

        }
        public DbSet<Event> Events { get; set; }

        public DbSet<Volunteer> Volunteers { get; set; }

        public DbSet<Response> Responses { get; set; }


    }
}
