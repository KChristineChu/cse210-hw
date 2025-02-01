using System;

public class Customer
{
    private string _customer;
    private Address _address;

    public Customer (string customer, Address address)
    {
        _customer = customer;
        _address = address;
    }

    public void DisplayCustomInfo()
    {
        Console.WriteLine($"Customer: {_customer}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
    }

    public bool LiveInUsa()
    {
        return _address.IsUsa();
    }
}