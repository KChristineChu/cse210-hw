using System;

public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer (string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    
    public void DisplayCustomerInfo()
    {
        Console.WriteLine($"Customer: {_customerName}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
    }

    public bool LiveInUsa()
    {
        return _address.IsUsa();
    }
}