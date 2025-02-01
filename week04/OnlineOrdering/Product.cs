using System;

public class Product
{
    private string _productName;
    private string _productId;

    private int _quantity;
    private int _price;

    public Product(string productName, string productId, int quantity, int price)
    {
        _productName = productName;
        _productId = productId;
        _quantity = quantity;
        _price = price;

    }


    public double TotalCost()
    {
        
        return _quantity * _price;
    }
}


    
