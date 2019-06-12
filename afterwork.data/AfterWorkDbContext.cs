using afterwork.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace afterwork.data
{
   public class AfterWorkDbContext : DbContext
    {

        public AfterWorkDbContext(DbContextOptions<AfterWorkDbContext> options)
           : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MeetUpAdministrator>().HasKey(ea => new { ea.MeetUpId, ea.UserId });
            modelBuilder.Entity<MeetUpPartisipant>().HasKey(ep => new { ep.MeetUpId, ep.UserId });
        }

        public DbSet<MeetUp> MeetUps { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<MeetUpImage> MeetUpImages { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
