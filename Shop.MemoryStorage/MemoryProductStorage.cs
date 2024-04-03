using System.Diagnostics.CodeAnalysis;
using Shop.Entities;
using Shop.Interfaces;

namespace Shop.MemoryStorage;

public class MemoryProductStorage : IProductStorage
{
	private readonly Product[] _products =
	[
		new Product(1)
		{
			Title = "Gold coin",
			Description = "Pretty gold coin",
			Price = 10.99m,
		},
		new Product(2)
		{
			Title = "Silver plate",
			Description = "Small silver plate",
			Price = 12.99m,
		},
		new Product(3)
		{
			Title = "Gold ring",
			Description = "Ordinary gold ring",
			Price = 29.99m,
		},
	];

	public IEnumerable<Product> GetAllProducts()
	{
		return _products;
	}
	
	public bool TryGetProductById(int id, [MaybeNullWhen(false)]out Product product)
	{
		product = _products.SingleOrDefault(p=>p.Id == id);
		return product != null;
	}
}