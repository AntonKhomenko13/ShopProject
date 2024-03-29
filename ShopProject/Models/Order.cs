namespace ShopProject
{
    internal class Order : IID
    {
        public int ID { get; set; }

        public string OrderName { get; set; }

        public int SalesManagerId { get; set; }

        public int ClientId { get; set; }

        public double Sum { get; set; }

        public Order(string orderName, int salesManagerId, int clientId, double sum)
        {
            OrderName = orderName;
            SalesManagerId = salesManagerId;
            ClientId = clientId;
            Sum = sum;
        }

        public override string ToString()
        {
            return String.Format($"{ID} \t {OrderName} \t {SalesManagerId} \t {ClientId} \t {Sum}");
        }
    }
}