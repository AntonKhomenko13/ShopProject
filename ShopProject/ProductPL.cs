namespace ShopProject
{
    internal class ProductPL
    {
        ProductBLL productBLL;
        public ProductPL(ProductBLL productBLL)
        {
            this.productBLL = productBLL;
        }
        public void CreateProduct()
        {
            Console.Write("CreateProduct productName?: ");
            string productName = Console.ReadLine();
            productBLL.CreateProduct(productName);
        }
    }
}
