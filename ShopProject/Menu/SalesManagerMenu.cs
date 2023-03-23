using ShopProject.Menu;

namespace ShopProject
{
    internal class SalesManagerMenu : AbstractMenu
    {
        ClientCRUDMenu clientCRUDMenu;
        OrderCRUDMenu orderCRUDMenu;
        SalesManagerServicesMenu salesManagerServicesMenu;
        ConsoleColor defaultColor;

        public SalesManagerMenu(ClientCRUDMenu clientCRUDMenu, OrderCRUDMenu orderCRUDMenu, SalesManagerServicesMenu salesManagerServicesMenu)
        {
            this.clientCRUDMenu = clientCRUDMenu;
            this.orderCRUDMenu = orderCRUDMenu;
            this.salesManagerServicesMenu = salesManagerServicesMenu;
        }

        protected override void Init()
        {
            Flag = true;
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
                    Console.Clear();
                    Console.WriteLine("Client CRUD Menu");
                    clientCRUDMenu.Run();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Order CRUD Menu");
                    orderCRUDMenu.Run();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Sales Manager Services Menu");
                    salesManagerServicesMenu.Run();
                    break;
                case 4:
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