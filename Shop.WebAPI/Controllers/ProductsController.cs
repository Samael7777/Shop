using Microsoft.AspNetCore.Mvc;
using Shop.Entities;
using Shop.Interfaces;

namespace Shop.WebAPI.Controllers;

[Route("[controller]")]
[ApiController]
public class ProductsController(IProductStorage productStorage, ILogger<ProductsController> logger) 
	: ControllerBase
{
	[HttpGet]
	public IEnumerable<Product> Get()
	{
		return productStorage.GetAllProducts().ToArray();
	}
}