using Microsoft.EntityFrameworkCore;

namespace StudentAPI.Models
{
    public class APIDBcontext:DbContext
    {
        public APIDBcontext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Student> students { get; set; }
    }
}
