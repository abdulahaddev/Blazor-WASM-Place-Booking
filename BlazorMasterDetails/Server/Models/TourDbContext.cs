using BlazorMasterDetails.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorMasterDetails.Server.Models
{
    public class TourDbContext : DbContext
    {
        public TourDbContext(DbContextOptions<TourDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; } = default!;
        public DbSet<Spot> Spots { get; set; } = default!;
        public DbSet<BookingEntry> BookingEntries { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Spot>().HasData(
                    new Spot { SpotId = 1, SpotName = "Coxs Bazar"},
                    new Spot { SpotId = 2, SpotName = "Bandarban"},
                    new Spot { SpotId = 3, SpotName = "Rangamati"},
                    new Spot { SpotId = 4, SpotName = "Sylhet"},
                    new Spot { SpotId = 5, SpotName = "Rajshahi"},
                    new Spot { SpotId = 6, SpotName = "Kuakata"}
                );
        }
    }
}
