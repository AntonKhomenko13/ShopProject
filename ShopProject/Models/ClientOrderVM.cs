using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject
{
    internal class ClientOrderVM
    {
        public string ClientFirstName { get; set; }        
        public string ClientLastName { get; set; }
        public string OrderName { get; set; }
        public double Sum { get; set; }

        public ClientOrderVM(string clientFirstName, string clientLastName, string orderName, double sum)
        {
            ClientFirstName = clientFirstName;
            ClientLastName = clientLastName;
            OrderName = orderName;
            Sum = sum;
        }
        public override string ToString()
        {
            return string.Format(ClientFirstName + " " + ClientLastName + " " + OrderName + " " + Sum);
        }
    }
}
