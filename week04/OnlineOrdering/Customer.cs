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
    public bool LiveInUSA()
    {
        return _address.IsUsa();
    }

}
