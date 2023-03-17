namespace ShopProject
{
    internal class ProductManagerMenu : AbstractMenu
    {
        ConsoleColor defaultColor;
        protected override void Init()
        {
            defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
        protected override void Idle()
        {
            Console.WriteLine("1 - Product CRUD Menu");
            Console.WriteLine("2 - Product Manager Services Menu");
            Console.WriteLine("3 - Exit");

            int menuNumber = int.Parse(Console.ReadLine());
            switch (menuNumber)
            {
                case 1:
                    Console.WriteLine("Product CRUD Menu");
                    break;
                case 2:
                    Console.WriteLine("Product Manager Services Menu");
                    break;
                case 3:
                    Flag = false;
                    break;
                case 4:
                    Console.WriteLine("Input the right number!");
                    break;
            }
        }
        protected override void CleanUp()
        {
            Console.ForegroundColor = defaultColor;
        }
    }
}
