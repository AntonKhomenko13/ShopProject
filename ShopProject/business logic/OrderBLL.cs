namespace ShopProject.business_logic
{
    internal class OrderBLL
    {
        DB db;

        public OrderBLL(DB db)
        {
            this.db = db;
        }

        public void CreateOrder(string orderName, int salesManagerId, int clientId, double sum)
        {
            Order order = new Order(orderName, salesManagerId, clientId, sum);
            DBItem<Order> dbOrder = db.DBOrder;
            dbOrder.AddItem(order);
        }

        public Order GetByID(int id)
        {
            Order result = default(Order);
            result = db.DBOrder.GetById(id);
            return result;
        }

        public List<Order> GetAllOrders()
        {
            return db.DBOrder.Items;
        }

        public bool UpdateOrder(Order oldOrder, string orderName, int salesManagerId, int clientId, double sum)
        {
            bool result = false;
            Order newOrder = new Order(orderName, salesManagerId, clientId, sum);
            result = db.DBOrder.Update(oldOrder, newOrder);
            return result;
        }

        public bool DeleteOrder(Order order)
        {
            bool result = false;
            result = db.DBOrder.Delete(order);
            return result;
        }
    }
}