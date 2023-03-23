namespace ShopProject
{
    internal class DB
    {
        public DBItem<Category> DBCategory { get; set; } = new DBItem<Category>();
        public DBItem<Client> DBClient { get; set; } = new DBItem<Client>();
        public DBItem<HR> DBHR { get; set; } = new DBItem<HR>();
        public DBItem<Order> DBOrder { get; set; } = new DBItem<Order>();
        public DBItem<Product> DBProduct { get; set; } = new DBItem<Product>();
        public DBItem<ProductCategory> DBProductCategory { get; set; } = new DBItem<ProductCategory>();
        public DBItem<ProductManager> DBProductManager { get; set; } = new DBItem<ProductManager>();
        public DBItem<ProductOrder> DBProductOrder { get; set; } = new DBItem<ProductOrder>();
        public DBItem<SalesManager> DBSalesManager { get; set; } = new DBItem<SalesManager>();
        public DB()
        {
            Initialize();
        }
        private void Initialize()
        {
            ProductInitialize();
            CategoryInitialize();
            ProductCategoryInitialize();
            ClientInitialize();
            OrderInitialize();
        }
        private void ProductInitialize()
        {
            Product product1 = new Product("Product1");
            DBProduct.AddItem(product1);
            Product product2 = new Product("Product2");
            DBProduct.AddItem(product2);
        }
        private void CategoryInitialize()
        {
            Category category1 = new Category("Category1");
            DBCategory.AddItem(category1);
            Category category2 = new Category("Category2");
            DBCategory.AddItem(category2);
        }
        private void ProductCategoryInitialize()
        {
            ProductCategory productCategory1 = new ProductCategory(1, 2);
            DBProductCategory.AddItem(productCategory1);
            ProductCategory productCategory2 = new ProductCategory(1, 1);
            DBProductCategory.AddItem(productCategory2);
            ProductCategory productCategory3 = new ProductCategory(2, 1);
            DBProductCategory.AddItem(productCategory3);
        }
        private void ClientInitialize()
        {
            Client client1 = new Client("Petro", "Petrenkoryk", 20);
            DBClient.AddItem(client1);
            Client client2 = new Client("Sergiy", "Sergiyenko", 25);
            DBClient.AddItem(client2);
            Client client3 = new Client("Volodimir", "Volodumiryk", 18);
            DBClient.AddItem(client3);
        }
        private void OrderInitialize()
        {
            Order order1 = new Order("Order1", 1, 1, 200);
            DBOrder.AddItem(order1);
            Order order2 = new Order("Order2", 1, 2, 300);
            DBOrder.AddItem(order2);
            Order order3 = new Order("Order3", 1, 3, 400);
            DBOrder.AddItem(order3);
            Order order4 = new Order("Order4", 1, 1, 100);
            DBOrder.AddItem(order4);
            Order order5 = new Order("Order5", 1, 2, 50);
            DBOrder.AddItem(order5);
        }
    }
}
