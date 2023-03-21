namespace ShopProject;

internal class ProductCRUDMenu : AbstractMenu
{
    ConsoleColor defaultColor;
    public Product Product { get; set; }

    public ProductCRUDMenu(Product product)
    {
        Product = product;
    }

    protected override void CleanUp()
    {
        Console.ForegroundColor = defaultColor;
    }

    protected override void Init()
    {
        Flag = true;
        Console.Clear();
        defaultColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
    }

    protected override void Idle()
    {
        Console.WriteLine("1 - Create");
        Console.WriteLine("2 - Read");
        Console.WriteLine("3 - Update");
        Console.WriteLine("4 - Delete");
        Console.WriteLine("5 - Exit");

        int menuNumber = int.Parse(Console.ReadLine() ?? string.Empty);
        switch (menuNumber)
        {
            case 1:
                Console.WriteLine("Create");
                break;
            case 2:
                Console.WriteLine("Read");
                break;
            case 3:
                Console.WriteLine("Update");
                break;
            case 4:
                Console.WriteLine("Delete");
                break;
            case 5:
                Flag = false;
                break;
            default:
                Console.WriteLine("Invalid number!");
                break;
        }
    }
}