using Microsoft.EntityFrameworkCore;
using radnom_web.Models;

namespace radnom_web.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }
    public DbSet<Custumer> Custumers { get; set; }
    }
}   
