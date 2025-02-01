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


    public static int TotalCost(int quantity, int price)
    {
        int _quantity = quantity;
        int _price = price;

        return quantity * price;
    }
}


    
