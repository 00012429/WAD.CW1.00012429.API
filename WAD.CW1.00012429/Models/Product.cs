namespace WAD.CW1._00012429.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public ICollection<Feedback> Feedbacks { get; set; }
	}
}
