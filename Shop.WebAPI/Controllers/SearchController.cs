using Microsoft.AspNetCore.Mvc;
using Shop.Entities;
using Shop.Interfaces;

namespace Shop.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SearchController(ISearchService searchService) 
	: ControllerBase
{
	[HttpGet("{query}")]
	public IEnumerable<Product> Get(string? query)
	{
		return searchService.FindProducts(query);
	}
}