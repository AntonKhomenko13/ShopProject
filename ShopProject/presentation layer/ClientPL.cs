using ShopProject.business_logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject.presentation_layer
{
    internal class ClientPL
    {
        ClientBLL clientBLL;
        public ClientPL(ClientBLL clientBLL)
        {
            this.clientBLL = clientBLL;
        }
        public void CreateClient()
        {
            Console.Write("CreateClient clientFirstName?: ");
            string clientFirstName = Console.ReadLine();
            Console.Write("CreateClient clientLastName?: ");
            string clientLastName = Console.ReadLine();
            Console.Write("CreateClient clientAge?(int): ");
            int clientAge = int.Parse(Console.ReadLine());
            clientBLL.CreateClient(clientFirstName, clientLastName, clientAge);
        }
        public void GetClientByID()
        {
            Console.Write("GetClientByID id?: ");
            int id = int.Parse(Console.ReadLine());
            Client result = clientBLL.GetByID(id);
            if (result == default(Client))
            {
                Console.WriteLine("Not found.");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
        public void GetAllClients()
        {
            List<Client> clients = clientBLL.GetAllClients();
            if (clients == null)
            {
                Console.WriteLine("Not found.");
            }
            else
            {
                foreach (Client client in clients)
                {
                    Console.WriteLine(client);
                }
            }
        }
        public void UpDateClient()
        {
            string clientFirstName = "";
            string clientLastName = "";
            int clientAge = 0;
            bool isDone = false;
            Console.Write("UpDateClient id?: ");
            int id = int.Parse(Console.ReadLine());
            Client oldItem = clientBLL.GetByID(id);
            if (oldItem == default(Client))
            {
                Console.WriteLine("Not found.");
            }
            else
            {
                Console.Write(oldItem.FirstName + " " +  oldItem.LastName + " " + oldItem.Age + " | Is it Ok?(y/n): ");
                if ("y" == Console.ReadLine())
                {
                    clientFirstName = oldItem.FirstName;
                    clientLastName = oldItem.LastName;
                    clientAge = oldItem.Age;
                }
                else
                {
                    Console.WriteLine("Enter new values");
                    Console.Write("clientFirstName?: ");
                    clientFirstName = Console.ReadLine();
                    Console.Write("clientLastName?: ");
                    clientLastName = Console.ReadLine();
                    Console.Write("clientAge?(int): ");
                    clientAge = int.Parse(Console.ReadLine());

                }
                Console.Write(clientFirstName + " " + clientLastName + " " + clientAge + " | Is it Ok?(y/n): ");
                if ("y" == Console.ReadLine())
                {
                    isDone = clientBLL.UpDateClient(oldItem, clientFirstName, clientLastName, clientAge);
                    if (isDone)
                    {
                        Console.WriteLine("Updated.");
                    }
                    else
                    {
                        Console.WriteLine("Error.");
                    }
                }
                else
                {
                    Console.WriteLine("Not updated.");
                }
            }
        }
        public void DeleteClient()
        {
            bool isDone = false;
            Console.Write("DeleteClient id?: ");
            int id = int.Parse(Console.ReadLine());
            Client result = clientBLL.GetByID(id);

            if (result == default(Client))
            {
                Console.WriteLine("Not found.");
            }
            else
            {
                isDone = clientBLL.DeleteClient(result);
                if (isDone)
                {
                    Console.WriteLine("Delited.");
                }
                else
                {
                    Console.WriteLine("Error.");
                }
            }
        }
    }
}
