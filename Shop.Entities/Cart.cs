namespace Shop.Entities;

public class Cart
{
	public IDictionary<int, int> Items { get; set; } = new Dictionary<int, int>();
	public decimal Amount { get; set; }
}