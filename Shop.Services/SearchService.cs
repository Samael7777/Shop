using Shop.Entities;
using Shop.Interfaces;

namespace Shop.Services;

public class SearchService(IProductStorage storage) : ISearchService
{
	public Product[] FindProducts(string? query)
	{
		if (string.IsNullOrWhiteSpace(query))
			return storage.GetAllProducts().ToArray();

		return storage.GetAllProducts().Where((p) => 
				p.Title.Contains(query, StringComparison.CurrentCultureIgnoreCase)
				|| p.Description.Contains(query, StringComparison.CurrentCultureIgnoreCase))
			.ToArray();
	}
}