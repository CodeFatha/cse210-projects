using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new();
        customer.SetName("Amir Ahmid");
        customer.SetAddress(new Address("47 Mohammed Street", "Dubai", "Dubai", "UAE"));

        Product p1 = new Product("Perfume", "239D384", 56, 2);
        Product p2 = new Product("Quad bike", "ATV200e", 1529.99, 1);
        Product p3 = new Product("Paly Station", "PS5", 489.49, 1);
        List<Product> products = [p1, p2, p1, p3];
        Order order1 = new Order(products, customer);
        OutPutText(order1);

        Customer customer2 = new();
        customer2.SetName("Charles Buckley");
        customer2.SetAddress(new Address("21 Jump Street", "Los Angeles", "Carlifornia", "USA"));

        Product prod1 = new Product("Bread", "LOB4564", 1, 1);
        Product prod2 = new Product("Eggs", "T30-2345", 18, 1);
        Product prod3 = new Product("Butter", "US9392", 7, 1);
        products.Clear();
        products = [prod1, prod2, prod3];
        Order order2 = new Order(products, customer2);
        OutPutText(order2);
    }

    public static void OutPutText(Order order)
    {
        Console.WriteLine($"PACKING LABEL:\n{order.PackingLabel()} \nSHIPPING LABEL:\n{order.ShippingLabel()} \nTotal Price: {order.CostOfOrder()}\n");
    }
}