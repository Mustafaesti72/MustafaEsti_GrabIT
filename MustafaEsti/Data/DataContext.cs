using Microsoft.EntityFrameworkCore;
using WebApi.Entities;

namespace MustafaEsti.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
