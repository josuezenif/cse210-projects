public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double TotalCost()
    {
        double cost = _price * _quantity;
        return cost;
    }

    public void PackingLabel()
    {
        Console.WriteLine($"{_name}: {_productId}");
    }
}