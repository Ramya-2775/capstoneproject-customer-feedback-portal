using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using capstone_project.Models;

namespace capstone_project.Data
{
    public class capstone_projectContext : DbContext
    {
        public capstone_projectContext (DbContextOptions<capstone_projectContext> options)
            : base(options)
        {
        }



        public DbSet<capstone_project.Models.Feedback> Feedback { get; set; } = default!;

        public DbSet<capstone_project.Models.Admin> Admin { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Admin>().HasData(
                new Admin
                {
                    Id = 1,
                    Username = "Ramya",
                    Password = "Ramya123"
                }
            );
        }
    }
}
