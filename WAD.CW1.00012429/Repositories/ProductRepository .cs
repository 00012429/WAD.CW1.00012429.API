using WAD.CW1._00012429.Data;
using WAD.CW1._00012429.Interfaces;
using WAD.CW1._00012429.Models;

namespace WAD.CW1._00012429.Repositories
{
	public class ProductRepository : IProductRepository
	{
		private readonly ApplicationDbContext _context;

		public ProductRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public IEnumerable<Product> GetAll()
		{
			return _context.Products.ToList();
		}

		public Product GetById(int id)
		{
			return _context.Products.Find(id);
		}

		public void Add(Product product)
		{
			_context.Products.Add(product);
			_context.SaveChanges();
		}

		public void Update(Product product)
		{
			_context.Products.Update(product);
			_context.SaveChanges();
		}

		public void Delete(Product product)
		{
			_context.Products.Remove(product);
			_context.SaveChanges();
		}
	}
}
