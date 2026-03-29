public class Customer
{
    private string _name;
    // Address _address;

    public Customer(string firstName)
    {
        _name = firstName;
    }

    public void LivesInUsa(Address address)
    {
        address.LivesInUsa(address);
    }

    public void DisplayName()
    {
        Console.WriteLine(_name);
    }

    // public void ShippingLabel()
    // {
    // Console.WriteLine(_name);
    //     _address.DisplayAddress();
    //     // Console.WriteLine(_address);
    // }
}