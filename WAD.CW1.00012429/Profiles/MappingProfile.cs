using static System.Runtime.InteropServices.JavaScript.JSType;
using WAD.CW1._00012429.DTOs;
using WAD.CW1._00012429.Models;

namespace WAD.CW1._00012429.Profiles
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			// Mapping from Entity to DTO
			CreateMap<Product, ProductDto>();
			CreateMap<Feedback, FeedbackDto>();

			// Mapping from DTO to Entity (if needed for POST/PUT operations)
			CreateMap<ProductDto, Product>();
			CreateMap<FeedbackDto, Feedback>();
		}
	}
}
