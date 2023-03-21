namespace ShopProject
{
    internal class ProductBLL
    {
        DB db;

        public ProductBLL(DB db)
        {
            this.db = db;
        }

        public void CreateProduct(string productName)
        {
            Product product = new Product(productName);
            DBItem<Product> dbProduct = db.DBProduct;
            dbProduct.AddItem(product);
        }
        public Product GetByID(int id)
        {
            Product result = default(Product);
            db.DBProduct
            return null;
        }
    }
}
