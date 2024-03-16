using Microsoft.EntityFrameworkCore;
using WAD.CW1._00012429.Data;
using WAD.CW1._00012429.Interfaces;
using WAD.CW1._00012429.Models;

namespace WAD.CW1._00012429.Repositories
{
	public class FeedbackRepository : IFeedbackRepository
	{
		private readonly ApplicationDbContext _context;

		public FeedbackRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public IEnumerable<Feedback> GetAllByProductId(int productId)
		{
			return _context.Feedbacks
						   .Where(f => f.ProductId == productId)
						   .Include(f => f.Product)
						   .ToList();
		}

		public Feedback GetById(int id)
		{
			var result = _context.Feedbacks
						   .Include(f => f.Product)
						   .FirstOrDefault(f => f.Id == id);

			if (result == null)
			{
				return new Feedback();
			}

			return result;
		}

		public void Add(Feedback feedback)
		{
			_context.Feedbacks.Add(feedback);
			_context.SaveChanges();
		}

		public void Update(Feedback feedback)
		{
			_context.Feedbacks.Update(feedback);
			_context.SaveChanges();
		}

		public void Delete(Feedback feedback)
		{
			_context.Feedbacks.Remove(feedback);
			_context.SaveChanges();
		}
	}
}
