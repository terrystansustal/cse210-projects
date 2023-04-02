
using System;
using System.Collections.Generic;

public class Order {
    // Attributes for the Order Class
    private string _packingLabel;
    private string _shippingLabel;
    private int _shippingCost;
    private double _totalCost = 0;
    private Customer _customer;
    private List<Product> _product = new List<Product>();


    // Constructors
    public Order ()
    {}

    public Order (string packingLabel, string shippingLabel)
    {
        _packingLabel = packingLabel;
        _shippingLabel = shippingLabel;
    }

    public Order (List<Product> product, Customer customer)
    {
        _product = product;
        _customer = customer;

        if (_customer.GetIsInUSA())
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }
    }

    // Set up Getters
    public int GetShippingCost()
    {
        return _shippingCost;
    }

    public double GetTotalCost()
    {
        return _totalCost;
    }

    public string GetPackingLabel()
    {
        foreach (Product product in _product)
        {
            _packingLabel += product.GetNameofProduct() + " (ID: " + product.GetProductID() + ")\n";
        }
        return _packingLabel;
    }

    public Customer GetShippingLabel()
    {   
        _customer.GetAddress();
        return _customer;
    }

    // Method
    public double CalculateTotalCost()
    {
        foreach (Product product in _product)
        {
            _totalCost += product.GetPrice();
        }
        return Math.Round(_totalCost + _shippingCost, 2); // Round the value to two decimal points
    }
}