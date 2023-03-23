using ShopProject.business_logic;

namespace ShopProject.presentation_layer
{
    internal class OrderPL
    {
        OrderBLL orderBLL;

        public OrderPL(OrderBLL orderBLL)
        {
            this.orderBLL = orderBLL;
        }

        public void CreateOrder()
        {
            Console.Write("CreateOrder orderName?: ");
            string orderName = Console.ReadLine();
            Console.Write("CreateOrder salesManagerID?: ");
            int salesManagerID = int.Parse(Console.ReadLine());
            Console.Write("CreateOrder clientID?: ");
            int clientID = int.Parse(Console.ReadLine());
            Console.Write("CreateOrder sum?: ");
            double sum = double.Parse(Console.ReadLine());
            orderBLL.CreateOrder(orderName, salesManagerID, clientID, sum);
        }
        public void GetOrderByID()
        {
            Console.Write("GetOrderByID id?: ");
            int id = int.Parse(Console.ReadLine());
            Order result = orderBLL.GetByID(id);
            if (result == default(Order))
                Console.WriteLine("Not found.");
            else
                Console.WriteLine(result);
        }
        public void GetAllOrders()
        {
            List<Order> orders = new List<Order>();
            if (orders != null)
                foreach (Order order in orderBLL.GetAllOrders())
                    Console.WriteLine(order);
            else
                Console.WriteLine("Not found.");
        }
        public void UpdateOrder()
        {
            // доробити...
            Console.WriteLine("Empty method");
        }

        public void DeleteOrder()
        {
            bool isDone = false;
            Console.Write("DeleteOrder id?: ");
            int id = int.Parse(Console.ReadLine());
            Order result = orderBLL.GetByID(id);
            if (result != default(Order))
            {
                isDone = orderBLL.DeleteOrder(result);
                if (isDone)
                    Console.WriteLine("Deleted");
                else
                    Console.WriteLine("Error.");
            }
            else
                Console.WriteLine("Not found.");
        }
    }
}