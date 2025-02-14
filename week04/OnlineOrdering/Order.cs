using System;
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
        if (_customer.GetFullAddress().IsUsa())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
    public float GetTotalPrice()
    {
        float sum = 0;

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
            Console.WriteLine($"Product name: {product.GetProductName()}, product ID: {product.GetProductId()}");
        }
    }
    public void DisplayShippingLabel()
    {
        Console.WriteLine($"Customer Name: {_customer.GetCustomer()}");
        Console.WriteLine($"Address: {_customer.GetFullAddress().GetAddress()}");
    }
}