using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityAssgnmnt.Areas.Identity.Data;
using IdentityAssgnmnt.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityAssgnmnt.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<City>()
                .HasOne(country => country.Country)
                .WithMany(cities => cities.Cities)
                .HasForeignKey(c=>c.CountryId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            builder.Entity<ApplicationUser>(b =>
            {
                b.HasOne(country => country.Country)
                    .WithMany(au => au.ApplicationUsers)
                    .HasForeignKey(au => au.CountryId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();

                b.HasOne(city => city.City)
                    .WithMany(au => au.ApplicationUsers)
                    .HasForeignKey(au => au.CityId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();

                seed(builder);
            });

            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        private void seed(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id=1,
                    Name = "Sweden"
                });

            builder.Entity<City>().HasData(
                new City
                {
                    Id = 1, CountryId = 1, Name = "Göteborg"

                });
        }

        public DbSet<IdentityAssgnmnt.Models.Country> Country { get; set; }

        public DbSet<IdentityAssgnmnt.Models.City> City { get; set; }
    }
}
