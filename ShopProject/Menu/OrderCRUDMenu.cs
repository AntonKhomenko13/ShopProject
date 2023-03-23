using ShopProject.presentation_layer;

namespace ShopProject
{
    internal class OrderCRUDMenu : AbstractMenu
    {
        OrderPL orderPL;
        ConsoleColor defaultColor;

        public OrderCRUDMenu(OrderPL orderPL)
        {
            this.orderPL = orderPL;
        }

        protected override void Init()
        {
            Flag = true;
            defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Magenta;
        }

        protected override void Idle()
        {
            Console.WriteLine("1 - Create");
            Console.WriteLine("2 - Get Order By ID");
            Console.WriteLine("3 - Get all orders");
            Console.WriteLine("4 - Update");
            Console.WriteLine("5 - Delete");
            Console.WriteLine("6 - Exit");

            int menuNumber = int.Parse(Console.ReadLine());
            switch (menuNumber)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Create");
                    orderPL.CreateOrder();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Get Order By ID");
                    orderPL.GetOrderByID();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Get all orders");
                    orderPL.GetAllOrders();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Update");
                    orderPL.UpdateOrder();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Delete");
                    orderPL.DeleteOrder();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 6:
                    Console.WriteLine("Exit");
                    Console.Clear();
                    Flag = false;
                    break;
                default:
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