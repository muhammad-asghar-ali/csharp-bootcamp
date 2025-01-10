using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OurHeros.Model;

namespace OurHeros
{
    public class OurHeroDbContext(DbContextOptions<OurHeroDbContext> options) : DbContext(options)
    {
        // Registered DB Model in OurHeroDbContext file
        public required DbSet<OurHero> OurHeros { get; set; }

        /*
         OnModelCreating mainly used to configured our EF model
         And insert master data if required
        */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Setting a primary key in OurHero model
            modelBuilder.Entity<OurHero>().HasKey(x => x.Id);

            // Inserting record in OurHero table
            modelBuilder.Entity<OurHero>().HasData(
                new OurHero
                {
                    Id = 1,
                    FirstName = "System",
                    LastName = "",
                    IsActive = true,
                }
            );
        }

    }
}