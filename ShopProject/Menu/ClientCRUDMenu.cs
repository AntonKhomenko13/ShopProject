using ShopProject.business_logic;
using ShopProject.presentation_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject.Menu
{
    internal class ClientCRUDMenu : AbstractMenu
    {
        ConsoleColor defaultColor;
        
        public Client Client { get; set; }

        ClientPL clientPL;

        public ClientCRUDMenu(Client client, ClientPL clientPL)
        {
            Client = client;
            this.clientPL = clientPL;
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
            Console.ForegroundColor = ConsoleColor.DarkRed;
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
                    Console.Clear();
                    Console.WriteLine("Create");
                    clientPL.CreateClient();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Read");
                    clientPL.GetClientByID();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Update");
                    clientPL.UpDateClient();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Delete");
                    clientPL.DeleteClient();
                    break;
                case 5:
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
