namespace ShopProject
{
    internal class SalesManagerMenu : AbstractMenu
    {
        ConsoleColor defaultColor;
        protected override void Init()
        {
            defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        protected override void Idle()
        {
            Console.WriteLine("1 - Client CRUD Menu");
            Console.WriteLine("2 - Order CRUD Menu");
            Console.WriteLine("3 - Sales Manager Services Menu");
            Console.WriteLine("4 - Exit");

            int menuNumber = int.Parse(Console.ReadLine());
            switch (menuNumber)
            {
                case 1:
                    Console.WriteLine("Client CRUD Menu");
                    break;
                case 2:
                    Console.WriteLine("Order CRUD Menu");
                    break;
                case 3:
                    Console.WriteLine("Sales Manager Services Menu");
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
