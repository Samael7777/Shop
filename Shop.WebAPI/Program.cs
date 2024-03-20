using Microsoft.AspNetCore.Server.Kestrel.Core;
using Shop.Interfaces;
using Shop.MemoryStorage;

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

			var app = builder.Build();
			// Configure the HTTP request pipeline.

			app.UseHttpsRedirection();

			app.UseAuthorization();

			app.MapControllers();

			app.Run();
		}
	}
}
