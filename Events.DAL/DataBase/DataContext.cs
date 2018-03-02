using Events.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.DAL.DataBase
{
    public class DataContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<AgeRange> AgeRanges { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=Events;User Id=postgres;Password=postgres;");
        }
    }
}
