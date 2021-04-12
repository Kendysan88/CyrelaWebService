using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}        

        public DbSet<ActiveType> ActiveTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<User>().Property(x => x.Id).ValueGeneratedOnAdd();
            // modelBuilder.HasPostgresExtension("uuid-ossp")
            //        .Entity<User>()
            //        .Property(e => e.Id)
            //        .HasDefaultValueSql("uuid_generate_v4()");
        }
    }
}
