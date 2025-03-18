public class Order
{
    private List<Product> _products = new();
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double CostOfOrder(double shipping = 5)
    {
        shipping = _customer.LiveInUSA() ? shipping : 35;
        return _products.Sum(product => product.TotalPrice()) + shipping;
    }

    public string PackingLabel()
    {
        List<string> products = new();

        foreach (var product in _products)
        {
            products.Add($"{product.GetName()} - {product.GetID()}");
        }

        return string.Join('\n', products);
    }
    public string ShippingLabel()
    {

        return $"{_customer.GetName()}\n{_customer.GetCustomerAddress()}";
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}