namespace Shop.Entities;

public class Product(int id)
{
	public int Id => id;
	public int CategoryId { get; set; }
	public string Title { get; set; } = "";
	public string Description { get; set; } = "";
	public decimal Price { get; set; }
}