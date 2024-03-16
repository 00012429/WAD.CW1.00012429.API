namespace WAD.CW1._00012429.Models
{
	public class Feedback
	{
		public int FeedbackId { get; set; }
		public string Content { get; set; }
		public DateTime DateCreated { get; set; }
		public int ProductId { get; set; }
		public Product Product { get; set; }
	}
}
