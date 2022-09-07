using BootcampMaintainer.Models;
using Microsoft.EntityFrameworkCore;

namespace BootcampMaintainer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
