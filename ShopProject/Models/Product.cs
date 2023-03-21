namespace ShopProject;

public class Product : IID
{
    public int ID { get; set; }
    public string ProductName { get; set; }

    public Product(string productName)
    {
        ProductName = productName;
    }

    public override string ToString()
    {
        return $"{ID} {ProductName}";
    }
}