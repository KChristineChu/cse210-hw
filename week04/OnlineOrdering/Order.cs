using System;
using System.Collections.Generic;


public class Order
{
    private List<Product> _products;
    private Customer _customer;

 public Order(Customer customer, List<Product> products)
 {
    _customer = customer;
    _products = products;
 }   
  
  public float GetShippingCost()
  {
    return _customer.Address.IsUsa() ? 5 : 35;

    
  }
  
  public double GetTotalPrice()
  {
      double sum = 0;

      foreach (var product in _products)
      {
        sum += product.TotalCost();
      }
      return sum + GetShippingCost();
}

    public void DisplayPackingLabel()
    {
        foreach (var product in _products)
        {
            Console.WriteLine($"Product name: {product.ProductName}, product ID: {product.ProductId}");
        }
    } 

    public void DisplayShippingLabel()
    {
        Console.WriteLine($"Customer Name: {_customerName}");
        Console.WriteLine($"Address: {_customer.Address.GetAddress()}");
    }   
}