using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("55 Cherry Lane", "Seattle", "Washington", "USA");
        Customer customer1 = new Customer("Julie Brown", address1);
        
        Product product1 = new Product("notebook", "123", 2, 3);
        Product product2 = new Product("marker", "124", 2, 4);
        Product product3 = new Product("pen", "125", 4, 1);

        Address address2 = new Address("67 Cedar street", "Cityvill", "Toronto", "Canada");
        Customer customer2 = new Customer("Ian Jacobson", address2);

        Product product4 = new Product("picture frame", "126", 5, 2);
        Product product5 = new Product("book stand", "127", 1, 9);

        List<Product> products1 = new List<Product> {product1, product2, product3};
        Order order1 = new Order(customer1, products1);

        List<Product> products2 = new List<Product> {product4, product5};
        Order order2 = new Order(customer1, products1);

        Console.WriteLine("Order 1: ");
        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");
  
        Console.WriteLine("Order 2: ");
        order2.DisplayPackingLabel();
        order2.DisplayShippingLabel();
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
  
    }
}