using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject
{
    internal class SMServivesPL
    {
        SMServicesBLL smServicesBLL;

        public SMServivesPL(SMServicesBLL smServicesBLL)
        {
            this.smServicesBLL = smServicesBLL;
        }
        public void GetClientOrders()
        {
            List<ClientOrderVM> clientOrders = smServicesBLL.GetClientOrders();
            foreach (ClientOrderVM clientOrder in clientOrders)
            {
                Console.WriteLine(clientOrder);
            }
        }
        public void GetClientSum()
        {
            List<ClientSumVm> clientSums = smServicesBLL.GetClientSum();
            foreach (ClientSumVm clientSumVm in clientSums)
            {
                Console.WriteLine(clientSumVm);
            }
        }
    }
}
