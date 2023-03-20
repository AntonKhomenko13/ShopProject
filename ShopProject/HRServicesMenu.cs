namespace ShopProject
{
    internal class HRServicesMenu : AbstractMenu
    {
        ConsoleColor defaultColor;
        protected override void Init()
        {
            defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
        }
        protected override void Idle()
        {
            Console.WriteLine("1 - Create");
            Console.WriteLine("2 - Read");
            Console.WriteLine("3 - Update");
            Console.WriteLine("4 - Delete");
            Console.WriteLine("5 - Exit");

            int menuNumber = int.Parse(Console.ReadLine());
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
                    Console.WriteLine("Exit");
                    Flag = false;
                    break;
                case 6: 
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