using Microsoft.EntityFrameworkCore;
using RegisterForm.Models;

namespace RegisterForm.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }
        public DbSet<User> Users { get; set; }
    }
}
