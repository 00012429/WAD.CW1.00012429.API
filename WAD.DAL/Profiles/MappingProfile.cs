using AutoMapper;
using WAD.CW1._00012429.DTOs;
using WAD.CW1._00012429.Models;

namespace WAD.CW1._00012429.Profiles
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			// Mapping from Entity to DTO
			CreateMap<Product, ProductDTO>();
			CreateMap<Feedback, FeedbackDTO>();

			// Mapping from DTO to Entity (if needed for POST/PUT operations)
			CreateMap<ProductDTO, Product>();
			CreateMap<FeedbackDTO, Feedback>();
		}
	}
}
