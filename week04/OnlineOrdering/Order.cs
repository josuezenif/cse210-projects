public class Order
{
    private List<Product> _productsList = new List<Product>();
    private List<Customer> _customersList = new List<Customer>();
    private List<Address> _addressList = new List<Address>();


    public void AddProduct(Product product)
    {
        _productsList.Add(product);
    }

    public void AddCustomer(Customer customer)
    {
        _customersList.Add(customer);
    }

    public void AddAddress(Address address)
    {
        _addressList.Add(address);
    }

    public double TotalCostOrder(Product product, Address address)
    {
        if (address.LivesInUsa(address) == true)
        {
            double totalCost = product.TotalCost() + 5;
            return totalCost;
        }
        else
        {
            double totalCost = product.TotalCost() + 35;
            return totalCost;
        }
    }

    public void PackingLabel()
    {
        foreach (Product product in _productsList)
        {
            product.PackingLabel();
        }
    }

    public void ShippingLabel()
    {
        foreach (Address address in _addressList)
        {
            address.DisplayAddress();
        }
    }
}