using System;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<TotalNumbers> TotalNumbers { get; set; }


    }
}

