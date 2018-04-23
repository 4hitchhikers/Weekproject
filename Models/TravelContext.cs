using Microsoft.EntityFrameworkCore;

namespace WeekProject.Models
{
    public class TravelContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public TravelContext(DbContextOptions<TravelContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Picture> Pictures { get; set; }
    }
}