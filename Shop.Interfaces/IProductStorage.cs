using System.Diagnostics.CodeAnalysis;
using Shop.Entities;

namespace Shop.Interfaces;

public interface IProductStorage
{
	public IEnumerable<Product> GetAllProducts();
	public bool TryGetProductById(int id, [MaybeNullWhen(false)]out Product product);
}