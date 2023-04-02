// Terrystan N. Sustal
// Final Project - Program 2

using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances for products
        Product product1 = new Product("iPhone 13 Pro", "P001", 899.99, 1);
        Product product2 = new Product("Samsung TV", "P002", 599.99, 2);
        Product product3 = new Product("Playstation 5", "P003", 699.99, 1);
        Product product4 = new Product("Acer Gaming Monitor", "P004", 199.99, 3);
        Product product5 = new Product("Hyper X: Quadcast S", "P005", 159.99, 1);

        // Create instances for addresses
        Address address1 = new Address("123 Vaness Ave.", "San Francisco", "CA", "USA");
        Address address2 = new Address("3304 San Jose Ave.", "Daly City", "CA", "USA");
        Address address3 = new Address("099 San Roque Hi-Way", "Naic", "Cavite", "PH");

        // Create instances for customers
        Customer customer1 = new Customer("James Garcia", address1);
        Customer customer2 = new Customer("Susan Sustal", address2);
        Customer customer3 = new Customer("Gigie Abella", address3);

        // Create instances for orders
        Order order1 = new Order(new List<Product> {product1, product2, product5}, customer1);
        Order order2 = new Order(new List<Product> {product3, product2, product4}, customer2);
        Order order3 = new Order(new List<Product> {product1, product2, product3, product4, product5}, customer3);

        // Call the methods to get the packing label, shipping label, and total price of the order
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel() + "'s Total Price:");
        Console.WriteLine("$" + order1.CalculateTotalCost());

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel() + "'s Total Price:");
        Console.WriteLine("$" + order2.CalculateTotalCost());

        Console.WriteLine("\nOrder 3:");
        Console.WriteLine("Packing Label:\n" + order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel() + "'s Total Price:");
        Console.WriteLine("$" + order3.CalculateTotalCost());
    }
}