using System;
using System.Diagnostics.CodeAnalysis;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

 public Order(Customer customer, List<Product> products)
 {
    _customer = customer;
    _products = products;
 }   
  public void GetTotalPrice(int quantity)
  {
      float sum = 0;

      foreach (var product in _products)
      {
        sum += product.TotalCost(quantity, price);

        return sum + shippingCost;
      
      }
      
}

    public void DisplayPackingLabel()
    {
        foreach (var product in _products)
        {
            Console.WriteLine($"Product name: {_productName}, product ID: {_productId}");
        }
    } 

    public void DisplayShippingLabel()
    {
        Console.WriteLine($"Customer Name: {_customer}");
        Console.WriteLine($"Address: {Address}");
    }   
}