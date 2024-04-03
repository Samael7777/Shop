﻿using Shop.Entities;

namespace Shop.Interfaces;

public interface IProductStorage
{
	public IEnumerable<Product> GetAllProducts();
	public Product? GetProductById(int id);
}