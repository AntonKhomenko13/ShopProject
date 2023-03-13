namespace ShopProject
{
    internal class DB
    {
        DBItem<Category> DBCategory { get; set; } = new DBItem<Category>();
        DBItem<Client> DBClient { get; set; } = new DBItem<Client>();
        DBItem<HR> DBHR { get; set; } = new DBItem<HR>();
        DBItem<Order> DBOrder { get; set; } = new DBItem<Order>();
        DBItem<Product> DBProduct { get; set; } = new DBItem<Product>();
        DBItem<ProductCategory> DBProductCategory { get; set; } = new DBItem<ProductCategory>();
        DBItem<ProductManager> DBProductManager { get; set; } = new DBItem<ProductManager>();
        DBItem<ProductOrder> DBProductOrder { get; set; } = new DBItem<ProductOrder>();
        DBItem<SalesManager> DBSalesManager { get; set; } = new DBItem<SalesManager>();
        public DB()
        {
            Initialize();
        }
        private void Initialize()
        {
            ProductInitialize();
            CategoryInitialize();
            ProductCategoryInitialize();
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
    }
}
