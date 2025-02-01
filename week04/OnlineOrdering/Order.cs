using System;
using System.Diagnostics.CodeAnalysis;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    
  public static float GetTotalPrice()
  {
      float sum = 0;
      foreach ()
      sum +=
      float finalSum = sum + shippingCost;
      return finalSum;
}

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