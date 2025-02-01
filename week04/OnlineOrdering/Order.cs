using System;
using System.Diagnostics.CodeAnalysis;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    //public float TotalCost(int productPrice, int quantity)
    //{
        //_productPrice = productPrice;
        //_quantity = quantity;
        
        //return productPrice * quantity;
    //}


//  public float GetTotalPrice()
//  {
//      float sum = 0;
//      foreach ()
//      sum +=
//      finalSum = sum + shippingCost;
//      return finalSum;
//}

    public void DisplayPackingLabel()
    {
        Console.WriteLine($"Product name: {_productName}, product ID: {_productId}");
    } 

    public void DisplayShippingLabel()
    {
        Console.WriteLine($"Customer Name: {_customer}");
        Console.WriteLine($"Address: {Address}");
    }   
}