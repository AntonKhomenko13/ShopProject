namespace ShopProject
{
    internal class Client : Person, IID
    {
        public int ID { get; set; }
        public Client(string firstName, string lastName, int age) : base(firstName, lastName, age) { }
        public override string ToString()
        {
            return string.Format($"{ID} {base.ToString()}");
        }
    }
}