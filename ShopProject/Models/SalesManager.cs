﻿namespace ShopProject
{
    internal class SalesManager : Person, IID
    {
        public int ID { get; set; }
        public int FirstName { get; private set; }
        public int LastName { get; private set; }
        public int Age { get; private set; }

        public SalesManager(string firstName, string lastName, int age) : base(firstName, lastName, age) { }
        public override string ToString()
        {
            return String.Format($"{ID} {base.ToString()}");
        }
    }
}