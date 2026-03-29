using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine();

        // creating orders using methods
        Order order1 = new Order();
        Customer customer1 = new Customer("Juan Sebastian");
        Address address1 = new Address("742 Evergreen Terrace", "Toronto", "Ontario", "Canada");
        Product product1 = new Product("Macbook Air", "LAP991", 629.99, 1);
        Product product2 = new Product("Airpods Pro Max XSE", "AIR592", 259.99, 1);
        Product product3 = new Product("SuperFast Charger", "CHA219", 12.59, 2);

        // adding customer name and products to lists and address
        order1.AddCustomer(customer1);
        order1.AddAddress(address1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);


        // creating second customer and their 2 products
        Order order2 = new Order();
        Customer customer2 = new Customer("MrBeast");
        Address address2 = new Address("701 Boulevard Lamontagne", "Greenville", "South Carolina", "USA");
        Product prod1Cus2 = new Product("32 inch 8k Screen TV", "TV8K16", 499.99, 2);
        Product prod2Cus2 = new Product("Iphone 17 Pro Plus Max", "IPRO17", 899.89, 4);
        Product prod3Cus2 = new Product("Feastables", "FAH215", 4.99, 50);

        // adding second order customer name and products and address
        order2.AddCustomer(customer2);
        order2.AddAddress(address2);
        order2.AddProduct(prod1Cus2);
        order2.AddProduct(prod2Cus2);
        order2.AddProduct(prod3Cus2);


        // first order packing label (info)
        Console.WriteLine();
        Console.WriteLine("First packing order label:");
        Console.WriteLine();
        order1.PackingLabel();
        Console.WriteLine();

        // shipping label
        customer1.DisplayName();
        order1.ShippingLabel();
        Console.WriteLine();

        // total price of the order 1 and products
        double price = order1.TotalCostOrder(product1, address1);
        double price2 = order1.TotalCostOrder(product2, address1);
        double price3 = order1.TotalCostOrder(product3, address1);
        double totalPrice = price + price2 + price3 - 70;
        Console.WriteLine($"The total price for these product plus shipping is: ${totalPrice.ToString("F2")}");
        Console.WriteLine();
        Console.WriteLine();


        // second packing label order and info
        Console.WriteLine();
        Console.WriteLine("Second packing order label:");
        Console.WriteLine();
        order2.PackingLabel();
        Console.WriteLine();

        // shipping label
        customer2.DisplayName();
        order2.ShippingLabel();
        Console.WriteLine();

        // total price for second order
        double price1ord2 = order2.TotalCostOrder(prod1Cus2, address2);
        double price2ord2 = order2.TotalCostOrder(prod2Cus2, address2);
        double price3ord2 = order2.TotalCostOrder(prod3Cus2, address2);
        double totalPriceOrd2 = price1ord2 + price2ord2 + price3ord2 - 10;
        Console.WriteLine($"Total price for second order: ${totalPriceOrd2.ToString("F2")}");
        Console.WriteLine();

    }
}