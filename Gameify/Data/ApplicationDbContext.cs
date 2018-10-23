using Gamey.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gameify.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Game> Game { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<PegiAge> PegiAge { get; set; }
        public DbSet<PegiContent> PegiContent { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
