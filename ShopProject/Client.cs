namespace ShopProject
{
    internal class Client : Person
    {
        public int ID { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public int Age { get; set; }

        public Client(string firstName, string lastName, int age) : base(firstName, lastName, age) { }
        public override string ToString()
        {
            return String.Format($"{ID} {base.ToString()}");
        }
    }
}