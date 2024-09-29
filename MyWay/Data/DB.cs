using Microsoft.EntityFrameworkCore;
using MyWay.Models;

namespace MyWay.Data
{
	public class DB : DbContext
	{
        public DB(DbContextOptions<DB> options) :base(options) { }
        
        public DbSet<Tour> Tours { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
