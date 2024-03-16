using WAD.CW1._00012429.Models;

namespace WAD.CW1._00012429.Interfaces
{
	public interface IFeedbackRepository
	{
		IEnumerable<Feedback> GetAllByProductId(int productId);
		Feedback GetById(int id);
		void Add(Feedback feedback);
		void Update(Feedback feedback);
		void Delete(Feedback feedback);
	}
}
