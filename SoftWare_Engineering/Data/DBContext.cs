using Microsoft.EntityFrameworkCore;
using SoftWare_Engineering.Models;

namespace SoftWare_Engineering.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
