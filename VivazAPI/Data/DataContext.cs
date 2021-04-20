using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using VivazAPI.Dtos;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public class DataContext : DbContext
    {   
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<User> Users { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<ActivityType> ActivityTypes { get; set; }
        public DbSet<AddressState> AddressStates { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Occurrence> Occurrences { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

    }
}
