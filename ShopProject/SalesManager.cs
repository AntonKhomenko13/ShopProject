namespace ShopProject
{
    internal class SalesManager
    {
        public int ID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public SalesManager(string firstName, string lastName, int age, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string ToString()
        {
            return String.Format(ID + " " + FirstName + " " + LastName + " " + Age);
        }
    }
}
