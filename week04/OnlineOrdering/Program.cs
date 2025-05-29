using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Online Ordering System");
        Console.WriteLine("======================\n");

        // Create first order (Ugandan customer)
        Address address1 = new Address("Plot 123 Kira Road", "Kampala", "Central", "Uganda");
        Customer customer1 = new Customer("James Okello", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Laptop Computer", "COMP-001", 899.99, 1);
        Product product2 = new Product("Wireless Mouse", "MOUSE-002", 29.99, 2);
        Product product3 = new Product("USB Cable", "CABLE-003", 12.50, 3);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Display first order details
        Console.WriteLine("ORDER #1");
        Console.WriteLine("--------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine();

        // Create second order (International customer)
        Address address2 = new Address("456 Maple Avenue", "Nairobi", "Nairobi County", "Kenya");
        Customer customer2 = new Customer("Grace Wambui", address2);
        Order order2 = new Order(customer2);

        Product product4 = new Product("Smartphone", "PHONE-004", 649.99, 1);
        Product product5 = new Product("Phone Case", "CASE-005", 24.99, 1);
        Product product6 = new Product("Screen Protector", "SCREEN-006", 9.99, 2);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        // Display second order details
        Console.WriteLine("ORDER #2");
        Console.WriteLine("--------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
        Console.WriteLine();

        // Create third order (Ugandan customer with multiple products)
        Address address3 = new Address("7 Bukoto Street", "Gulu", "Northern", "Uganda");
        Customer customer3 = new Customer("Agnes Adoch", address3);
        Order order3 = new Order(customer3);

        Product product7 = new Product("Gaming Headset", "HEAD-007", 79.99, 1);
        Product product8 = new Product("Mechanical Keyboard", "KEY-008", 129.99, 1);

        order3.AddProduct(product7);
        order3.AddProduct(product8);

        // Display third order details
        Console.WriteLine("ORDER #3");
        Console.WriteLine("--------");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order3.CalculateTotalCost():F2}");

        Console.WriteLine("\nProgram completed successfully!");
    }
}
