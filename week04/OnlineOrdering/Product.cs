using System;

public class Product
{
    private string _productName;
    private string _productId;

    private int _quantity;
    private int _price;

    


    public int TotalCost(int quantity, int price)
    {
        int _quantity = quantity;
        int _price = price;

        return quantity * price;
    }
}