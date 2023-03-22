namespace ShopProject
{
    internal class Client : Person, IID
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Client(string firstName, string lastName, int age) : base(firstName, lastName, age) { }
        public override string ToString()
        {
            return String.Format($"{ID} {base.ToString()}");
        }
    }
}