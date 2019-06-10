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
            modelBuilder.Entity<EventAdministrator>().HasKey(ea => new { ea.EventId, ea.UserId });
            modelBuilder.Entity<EventPartisipant>().HasKey(ep => new { ep.EventId, ep.UserId });
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<EventImage> EventImages { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
