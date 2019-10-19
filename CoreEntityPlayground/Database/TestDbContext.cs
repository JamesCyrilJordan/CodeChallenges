using CoreEntityPlayground.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreEntityPlayground.Database
{
	public class TestDbContext : DbContext
	{
		public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
		{
		}

		public DbSet<Achievement> Achievements { get; set; }
	}
}