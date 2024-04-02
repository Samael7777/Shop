using Microsoft.AspNetCore.Mvc;
using Shop.Entities;
using Shop.Interfaces;

namespace Shop.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SearchController(ILogger<ProductsController> logger) : ControllerBase
{
	[HttpGet]
	public IEnumerable<Product> Get(string? query, ISearchService searchService)
	{
		return searchService.FindProducts(query);
	}
}