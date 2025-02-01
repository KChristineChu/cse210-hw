using System;
using System.Collections.Concurrent;
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
  
  public float GetShippingCost()
  {
    return _customer.Address.IsUsa() ? 5 : 35;

    //float shippingFee;
    //if(_customer.Address.IsUsa())
    //{
       // shippingFee = 5;
    //}
    //else
    //{
        //shippingFee = 35;
    //}
    //return shippingFee;
  }
  
  public double GetTotalPrice(int quantity)
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
        Console.WriteLine($"Customer Name: {_customer}");
        Console.WriteLine($"Address: {_customer.Address.GetAddress()}");
    }   
}