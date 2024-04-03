using Microsoft.AspNetCore.Mvc;
using Shop.Entities;
using Shop.Interfaces;

namespace Shop.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController(IProductStorage productStorage) 
	: ControllerBase
{
	[HttpGet]
	public IEnumerable<Product> Get()
	{
		return productStorage.GetAllProducts().ToArray();
	}

	[HttpGet("{id:int}")]
	public Product? Get(int id)
	{
		return productStorage.GetProductById(id);
	}
}