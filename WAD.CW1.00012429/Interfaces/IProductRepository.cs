using WAD.CW1._00012429.Models;

namespace WAD.CW1._00012429.Interfaces
{
	public interface IProductRepository
	{
		IEnumerable<Product> GetAll();
		Product GetById(int id);
		void Add(Product product);
		void Update(Product product);
		void Delete(Product product);
	}
}
