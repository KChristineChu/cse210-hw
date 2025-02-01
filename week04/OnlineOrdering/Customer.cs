using System;

public class Customer
{
    private string _customer;
    public Address _address;

    public Customer (string customer, Address address)
    {
        _customer = customer;
        _address = address;

        Console.WriteLine($"Customer: {_customer}");
        Console.WriteLine($"Address: {_address}");
    }

    public void LiveInUsa()
    {

    }
}