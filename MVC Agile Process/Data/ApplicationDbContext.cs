using Microsoft.EntityFrameworkCore;
using MVC_Agile_Process.Models;

namespace MVC_Agile_Process.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
