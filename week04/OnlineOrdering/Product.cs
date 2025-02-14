using System;

public class Product
{
    private string _productName;
    private string _productId;
    private float _price;
    private int _quantity;
    public Product(string productName, string productId, float price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public float TotalCost()
    {
        return _price * _quantity;
    }
}