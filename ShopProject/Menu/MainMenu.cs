namespace ShopProject
{
    internal class MainMenu : AbstractMenu
    {
        HrMenu hrMenu;
        ProductManagerMenu productManagerMenu;
        SalesManagerMenu salesManagerMenu;
        ConsoleColor defaultColor;

        public MainMenu(HrMenu hrMenu, ProductManagerMenu productManagerMenu, SalesManagerMenu salesManagerMenu)
        {
            this.hrMenu = hrMenu;
            this.productManagerMenu = productManagerMenu;
            this.salesManagerMenu = salesManagerMenu;
        }

        protected override void Init()
        {
            Flag = true;
            defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        protected override void Idle()
        {
            Console.WriteLine("1 - HR Menu");
            Console.WriteLine("2 - Product Manager Menu");
            Console.WriteLine("3 - Sales Manager Menu");
            Console.WriteLine("4 - Exit");

            int menuNumber = int.Parse(Console.ReadLine());
            switch (menuNumber)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("HR Menu");
                    hrMenu.Flag = true;
                    hrMenu.Run();
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Product Manager Menu");
                    productManagerMenu.Flag = true;
                    productManagerMenu.Run();
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Sales Manager Menu");
                    salesManagerMenu.Flag = true;
                    salesManagerMenu.Run();
                    Console.Clear();
                    break;
                case 4:
                    Flag = false;
                    Console.Clear();
                    break;
                case 5:
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