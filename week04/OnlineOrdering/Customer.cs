public class Customer
{
    private string _name;
    private Address _address;

    public bool LiveInUSA()
    {
        return _address.IsUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetCustomerAddress()
    {
        return _address.GetAddress();
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }
}