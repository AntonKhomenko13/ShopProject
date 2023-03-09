using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject
{
    internal class HR:Person
    {
        public int ID { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Age { get; private set; }

        public HR (string firstName, string lastName, int age):base(firstName,lastName,age)
        {
        }
        public override string ToString()
        {
            return String.Format(ID + " " + base.ToString());
        }
    }
}
