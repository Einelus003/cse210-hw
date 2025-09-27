using System;

class Program
{
    static void Main(string[] args)
    {
        
        Address address1 = new Address("1128 e spruce ", "California ", "CA", "USA");
        Customer customer1 = new Customer("Emmanuel  Johnson", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Moto ", "P1001", 1999.50, 1));
        order1.AddProduct(new Product("Oil ", "P1002", 25.50, 2));

        
        Address address2 = new Address("416 Queen ", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Clerveaux  Smith", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product(" Lamp", "P2001", 45.00, 1));
        order2.AddProduct(new Product("book", "P2002", 5.75, 5));
        order2.AddProduct(new Product("Pen ", "P2003", 12.99, 2));

        
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}");
        Console.WriteLine(new string('-', 40));

        
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}");
    }
}
