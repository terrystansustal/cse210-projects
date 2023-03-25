
using System;

public class Address {
    // Attributes for the Address class
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    // Constructors
    public Address () 
    {}

    public Address (string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public string GetStreetAddress()
    {
        return _streetAddress;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetStateOrProvince()
    {
        return _stateOrProvince;
    }

    public string GetCountry()
    {
        return _country;
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"{_streetAddress}, {_city}, {_stateOrProvince}, {_country}");
    }
}