using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UserManagement.MVC.Models;

namespace UserManagement.MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
                        
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Country>().HasData(new Country
            {
                Id = 1,
                CountryName = "Egypt"
            },
            new Country
            {
                Id = 2,
                CountryName = "Saudia"
            }
            );

            builder.Entity<City>().HasData(
                    new City { Id = 1, CityName = "Jadda", CountryId = 2 },
                    new City { Id = 2, CityName = "Reiad", CountryId = 2 },
                    new City { Id = 3, CityName = "Mahala", CountryId = 1 },
                    new City { Id = 4, CityName = "Cairo", CountryId = 1 },
                    new City { Id = 5, CityName = "Mansoura", CountryId = 1 }
                    );
        }
    }
}
