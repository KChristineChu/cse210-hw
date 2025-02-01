using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("55 Cherry Lane, Seattle, Washington, USA");
        Customer customer1 = new Customer("Julie Brown", address1);
        
        Product product1 = new Product();
        product1._productName = "notebook";
        product1._productId = "123";
        product1._price = 3;
        product1._quantity = 2;

        Product product2 = new Product();
        product2._productName = "marker";
        product2._productId = "124";
        product2._price = 2;
        product2._quantity = 4;

        Product product3 = new Product();
        product3._productName = "pen";
        product3._productId = "125";
        product3._price = 4;
        product3._quantity = 1;

        Address address2 = new Address("67 Cedar street, Cityvill, Toronto, Canada");
        Customer customer2 = new Customer("Ian Jacobson", address2);
        
        Product product4 = new Product();
        product4._productName = "picture frame";
        product4._productId = "126";
        product4._price = 5;
        product4._quantity = 2;

        Product product5 = new Product();
        product5._productName = "book stand";
        product5._productId = "127";
        product5._price = 1;
        product5._quantity = 9;

        DisplayPackingLabel();

        DisplayShippingLabel();

        GetTotalPrice();
  

    }
}