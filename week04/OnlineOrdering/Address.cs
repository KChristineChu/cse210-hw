using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public string GetStreet
    {get; set;}
    public string GetCity
    {get; set;}
    public string GetState
    {get; set;}
    public string GetCountry
    {get; set;}
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public string DisplayAddress()
    {
        return $"{_street} \n{_city}, {_state} {_country}";
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