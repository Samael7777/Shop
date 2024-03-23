using Shop.Entities;
using Shop.Interfaces;

namespace Shop.MemoryStorage;

public class MemoryProductStorage : IProductStorage
{
	private readonly Product[] _products =
	[
		new Product(1, 1, "Product1", 100.12m),
		new Product(2, 1, "Product2", 999.99m),
		new Product(3, 1, "Product3", 42m),
	];

	public IEnumerable<Product> GetAllProducts()
	{
		return _products;
	}
}