using APITask.Models;
using Microsoft.EntityFrameworkCore;

namespace APITask.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
    }
}
