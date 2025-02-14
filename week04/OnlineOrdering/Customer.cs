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
    public string GetCustomer() 
    {
        return _customer;
    }
    public Address GetAddress()
     {
        return _address;
     }

    public string DisplayCustomerInfo()
    {
        return $"{_customer} {_address.GetAddress()}";
    }
    public bool LiveInUSA()
    {
        return _address.IsUsa();
    }

    
}
