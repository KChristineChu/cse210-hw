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
        if (_customer.Address.IsUsa())
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
            Console.WriteLine($"Product name: {Product._productName}, product ID: {Product._productId}");
        }
    }
    public void DisplayShippingLabel()
    {
        Console.WriteLine($"Customer Name: {_customer.Customer}");
        Console.WriteLine($"Address: {_customer.Address.DisplayAddress()}");
    }
}