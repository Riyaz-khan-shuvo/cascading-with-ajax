using CascadingDropdown.Models;
using Microsoft.EntityFrameworkCore;

namespace CascadingDropdown.Data
{
    public class CascadingDbContext : DbContext
    {
        public CascadingDbContext(DbContextOptions<CascadingDbContext> options) : base(options)
        {

        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
