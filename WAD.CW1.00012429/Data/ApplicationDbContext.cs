using Microsoft.EntityFrameworkCore;
using WAD.CW1._00012429.Models;

namespace WAD.CW1._00012429.Data
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Product> Products { get; set; }
		public DbSet<Feedback> Feedbacks { get; set; }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>()
				.HasMany(p => p.Feedbacks)
				.WithOne(f => f.Product)
				.HasForeignKey(f => f.ProductId);
		}
	}
}
