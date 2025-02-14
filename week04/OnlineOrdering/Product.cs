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
    public string GetProductName()
    {
        return _productName;
    }
    /*public void SetProductName(string productName)    //only when need to reset value
    {
        _productName = productName;
    }*/
    public string GetProductId()
    {
        return _productId;
    }
    public float TotalCost()
    {
        return _price * _quantity;
    }

}