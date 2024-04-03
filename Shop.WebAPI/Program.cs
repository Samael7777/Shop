using Shop.Interfaces;
using Shop.MemoryStorage;
using Shop.Services;

namespace Shop.WebAPI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();
			builder.Services.AddSingleton<IProductStorage, MemoryProductStorage>();
			builder.Services.AddSingleton<ISearchService, SearchService>();
			builder.Services.AddDistributedMemoryCache();
			builder.Services.AddSession(options =>
			{
				options.IdleTimeout = TimeSpan.FromMinutes(20);
				options.Cookie.IsEssential = true;
				options.Cookie.HttpOnly = true;
			});
			
			var app = builder.Build();
			
			// Configure the HTTP request pipeline.

			app.UseHttpsRedirection();

			app.UseAuthorization();
			app.UseSession();
			
			app.MapControllers();

			app.Run();
		}
	}
}
