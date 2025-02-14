using System;
using System.Net.Sockets;

public class Customer
{
    private string _customer;
    private Address _address;

    public Customer(string customer, Address address)
    {
        _customer = customer;
        _address = address;

    }
    public string GetCustomer {get; set;}
    public Address GetAddress { get; set; }

    public void DisplayCustomerInfo()
    {
        Console.WriteLine($"Customer: {_customer}");
        Console.WriteLine($"Address: {_address.DisplayAddress()}");
    }
    public bool LiveInUSA()
    {
        return _address.IsUsa();
    }

}
