using System.Data.Entity;
using WebApplication1.Models;

namespace WebApplication1
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
