
using System;

public class Product {
    // Attributes for the Product Class
    private string _nameOfProduct;
    private string _productID;
    private double _price;
    private int _quantity;

    // Constructors
    public Product ()
    {}

    public Product (string nameOfProduct, string productID, double price, int quantity)
    {
        _nameOfProduct = nameOfProduct;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    // Set up Getters

    public string GetNameofProduct()
    {
        return _nameOfProduct;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    // Method
    public void DisplayProductPrice()
    {
        double totalPrice = _price * _quantity;
        Console.WriteLine($"Total price of {_nameOfProduct}: {totalPrice}");
    }

}