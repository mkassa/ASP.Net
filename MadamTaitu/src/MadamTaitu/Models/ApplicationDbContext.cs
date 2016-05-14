using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using MadamTaitu.Models.Restaurant;

namespace MadamTaitu.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder  optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
