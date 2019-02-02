using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using XDelivered.Starter.Core.EF.Website.Data;

namespace XDelivered.StarterKits.NgCoreEF.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Entity> Entities { get; set; }
    }
}
