namespace ShopProject
{
    internal class MainMenu : AbstractMenu
    {
        HrMenu hrMenu;
        SalesManagerMenu salesManagerMenu;
        
        ConsoleColor defaultColor;

        public MainMenu(HrMenu hrMenu, SalesManagerMenu salesManagerMenu)
        {
            this.hrMenu = hrMenu;
            this.salesManagerMenu = salesManagerMenu;
        }

        protected override void Init()
        {
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
                    Console.WriteLine("HR Menu");
                    hrMenu.Flag = true;
                    hrMenu.Run();
                    break;
                case 2:
                    //productManager.Flag = true;
                    Console.WriteLine("Product Manager Menu");
                    break;
                case 3:
                    Console.WriteLine("Sales Manager Menu");
                    salesManagerMenu.Flag = true;
                    salesManagerMenu.Run();
                    break;
                case 4:
                    Flag = false;
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
