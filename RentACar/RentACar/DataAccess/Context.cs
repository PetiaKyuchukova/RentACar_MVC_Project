using Microsoft.EntityFrameworkCore;
using RentACar.Models;

namespace RentACar.DataAccess
{
    public class Context: DbContext
    {
        public Context(DbContextOptions options) : base(options) {}
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<City> Cities { get; set; }

    }
}
