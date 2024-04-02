using Shop.Entities;

namespace Shop.Interfaces;

public interface ISearchService
{
	public Product[] FindProducts(string? query);
}