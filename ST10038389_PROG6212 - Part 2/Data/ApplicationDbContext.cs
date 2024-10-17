using Microsoft.EntityFrameworkCore;
using ST10038389_PROG6212___Part_2.Models;

namespace ST10038389_PROG6212___Part_2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Claim> Claims { get; set; }
    }
}
