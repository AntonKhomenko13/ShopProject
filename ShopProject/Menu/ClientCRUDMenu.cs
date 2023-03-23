using ShopProject.presentation_layer;

namespace ShopProject.Menu
{
    internal class ClientCRUDMenu : AbstractMenu
    {
        ClientPL clientPL;
        ConsoleColor defaultColor;

        public ClientCRUDMenu(ClientPL clientPL)
        {
            this.clientPL = clientPL;
        }

        protected override void CleanUp()
        {
            Console.ForegroundColor = defaultColor;
        }

        protected override void Init()
        {
            Flag = true;
            defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }

        protected override void Idle()
        {
            Console.WriteLine("1 - Create");
            Console.WriteLine("2 - Get Client By ID");
            Console.WriteLine("3 - Get All Clients");
            Console.WriteLine("4 - Update");
            Console.WriteLine("5 - Delete");
            Console.WriteLine("6 - Exit");

            int menuNumber = int.Parse(Console.ReadLine() ?? string.Empty);
            switch (menuNumber)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Create");
                    clientPL.CreateClient();
                    Console.WriteLine();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Get Client By ID");
                    clientPL.GetClientByID();
                    Console.WriteLine();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Get All Clients");
                    clientPL.GetAllClients();
                    Console.WriteLine();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Update");
                    clientPL.UpDateClient();
                    Console.WriteLine();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Delete");
                    clientPL.DeleteClient();
                    Console.WriteLine();
                    break;
                case 6:
                    Console.Clear();
                    Flag = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid number!");
                    break;
            }
        }
    }
}