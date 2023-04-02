
using System;

public class Customer {
    // Attributes
    private string _customerName;
    private Address _address;

    public Customer ()
    {
        
    }
    
    public Customer (string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    // Set up Getters
    public string GetCustomerName()
    {
        return _customerName;
    }

    public Address GetAddress()
    {
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(_customerName);
        Console.WriteLine("Address:");
        _address.DisplayAddress();
        return _address;
    }

    public bool GetIsInUSA()
    {
        return _address.GetCountry() == "USA";
    }
    
}