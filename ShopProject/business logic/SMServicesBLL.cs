using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject
{
    internal class SMServicesBLL
    {
        DB db;

        public SMServicesBLL(DB db)
        {
            this.db = db;
        }

        public List<ClientOrderVM> GetClientOrders() 
        {
            List<ClientOrderVM> clientOrders = new List<ClientOrderVM>();

            foreach (Client client in db.DBClient.Items)
            {
                foreach (Order order in db.DBOrder.Items)
                {
                    if (client.ID == order.ClientId)
                    {
                        ClientOrderVM clientOrder = new ClientOrderVM(client.FirstName, client.LastName, order.OrderName, order.Sum);
                        clientOrders.Add(clientOrder);
                    }
                }
            }
            return clientOrders;
        }
        public List<ClientSumVm> GetClientSum()
        {
            double sum = 0;
            List<ClientSumVm> clientSums = new List<ClientSumVm>();
            foreach (Client client in db.DBClient.Items)
            {
                sum = 0;
                foreach (Order order in db.DBOrder.Items)
                {
                    if (client.ID == order.ClientId)
                    {
                        sum += order.Sum;
                    }
                }
                ClientSumVm clientSumVm = new ClientSumVm(client.FirstName, client.LastName, sum);
                clientSums.Add(clientSumVm);
            }
            return clientSums;
        }
    }
}
