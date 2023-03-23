using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject
{
    internal class ClientSumVm
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double Sum { get; set; }

        public ClientSumVm(string firstName, string lastName, double sum)
        {
            FirstName = firstName;
            LastName = lastName;
            Sum = sum;
        }
        public override string ToString()
        {
            return string.Format(FirstName + " " + LastName + " " + Sum);
        }
    }
}
