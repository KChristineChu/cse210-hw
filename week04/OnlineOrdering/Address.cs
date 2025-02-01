using System;
using System.Security.Authentication;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    //private bool _usa;


    public void GetAddress(string street, string city, string state, string country)   
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;

        Console.WriteLine($"Address: {_street} \n {_city} \n {_state}  {_country}");
    }

    public bool IsUsa()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}