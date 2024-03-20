using Shop.Entities;

namespace Shop.Interfaces;

public interface IProductStorage
{
	public IEnumerable<Product> GetAllProducts();
}