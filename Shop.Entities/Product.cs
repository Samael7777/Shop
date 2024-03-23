namespace Shop.Entities;

public class Product(int id, int categoryId, string title, decimal price)
{
	public int Id => id;
	public int CategoryId => categoryId;
	public string Title => title;
	public string Description { get; set; } = "";
	public decimal Price => price;
}