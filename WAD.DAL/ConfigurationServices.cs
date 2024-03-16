using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using WAD.CW1._00012429.Data;
using WAD.CW1._00012429.Interfaces;
using WAD.CW1._00012429.Repositories;

namespace WAD.DAL
{
	public static class ConfigurationServices
	{
		public static IServiceCollection ConfigureServicesDal(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
			services.AddAutoMapper(Assembly.GetExecutingAssembly());
			services.AddScoped<IFeedbackRepository, FeedbackRepository>();
			services.AddScoped<IProductRepository, ProductRepository>();

			return services;
		}
	}
}
