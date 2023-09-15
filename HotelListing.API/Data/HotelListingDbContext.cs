using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
                
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id=1,
                    Name="Serbia",
                    ShortName="SER"
                },
                new Country
                {
                    Id = 2,
                    Name = "Montenegro",
                    ShortName = "MNE"
                },
                new Country
                {
                    Id = 3,
                    Name = "Bosnia",
                    ShortName = "BIH"
                }
            );

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Kop",
                    Address = "Kopaonik",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "HN",
                    Address = "Herceg Novi",
                    CountryId = 2,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 3,
                    Name = "BL",
                    Address = "Banja Luka",
                    CountryId = 3,
                    Rating = 4
                }
            );
        }
    }
}
