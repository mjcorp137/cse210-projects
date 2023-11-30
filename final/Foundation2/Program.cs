using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address("261 tagapulot St.", "Cagayan de Oro", "Negros Oriental", "Philippines");
        Customer customer1 = new Customer("Mahonri Savedia", address1);
        List<Product> productsList1 = new List<Product>();

        Product p1001 = new Product("PS5", "3010D1", 20000.00, 1);
        Product p1002 = new Product("Mechanical Keyboard", "3010D2", 1500.00, 1);
        Product p1003 = new Product("Mouse Pad", "2010D2", 500.60, 1);

        productsList1.Add(p1001);
        productsList1.Add(p1002);
        productsList1.Add(p1003);

        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();
        Console.WriteLine();

        // Order 2
        Address address2 = new Address("319 Smoke St", "Digos", "Negros Occidental", "Philippines");
        Customer customer2 = new Customer("Blake Griffin", address2);
        List<Product> productsList2 = new List<Product>();

        Product p2001 = new Product("Black Hood", "3010D3", 500.99, 2);
        Product p2002 = new Product("Mp3 Player", "3020D4", 3000.25, 1);
        Product p2003 = new Product("Duck Tape", "5010D2", 3.50, 1);

        productsList2.Add(p2001);
        productsList2.Add(p2002);
        productsList2.Add(p2003);

        Order order2 = new Order(productsList2, customer2);

        Console.WriteLine("Order Number: 2");
        order2.DisplayResults();
        Console.WriteLine();

        // Order 3
        Address address3 = new Address("203 Helgen St.", "Cebu", "Misamis Occidental", "Philippines");
        Customer customer3 = new Customer("OG Shesh", address3);
        List<Product> productsList3 = new List<Product>();

        Product p3001 = new Product("Lolipop", "3010D2", 0.99, 4);
        Product p3002 = new Product("Straberry Jam", "3010D7", 2.99, 1);

        productsList3.Add(p3001);
        productsList3.Add(p3002);

        Order order3 = new Order(productsList3, customer3);

        Console.WriteLine("Order Number: 3");
        order3.DisplayResults();
        Console.WriteLine();
    }
}