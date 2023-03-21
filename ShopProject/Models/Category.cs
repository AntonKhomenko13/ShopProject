namespace ShopProject;

public class Category : IID
{
    public int ID { get; set; }
    public string Name { get; set; }

    public Category(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return $"{ID} {Name}";
    }
}