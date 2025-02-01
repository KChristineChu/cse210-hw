using System;

public class Product
{
    public string _productName;
    public string _productId;

    public int _quantity;
    public int _price;

    


    public int TotalCost(int quantity, int price)
    {
        int _quantity = quantity;
        int _price = price;

        return quantity * price;
    }
}