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
            result = db.DBProduct.GetById(id);
            return result;
        }
        public List<Product> GetAllProducts()
        {
            return db.DBProduct.Items;
        }
        public bool UpDateProduct(Product oldItem, string productName)
        {
            bool result = false;
            Product newItem = new Product(productName);
            result = db.DBProduct.Update(oldItem, newItem);
            return result;
        }
        public bool DeleteProduct(Product product)
        {
            bool result = false;
            result = db.DBProduct.Delete(product);
            return result;
        }
    }
}
