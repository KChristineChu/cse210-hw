using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer();
        Product product1 = new Product();
        product1._productName = "notebook";
        product1._productId = "1234";
        product1._price = 3;
        product1._quantity = 2;

    }
}