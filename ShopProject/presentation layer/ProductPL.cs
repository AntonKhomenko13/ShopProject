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
        public void GetProductByID ()
        {
            Console.Write("GetProductByID id?: ");
            int id = int.Parse(Console.ReadLine());
            Product result = productBLL.GetByID(id);
            if (result == default(Product))
            {
                Console.WriteLine("Not found.");
            }
            else
            {
                Console.WriteLine(result);
            }
        }

        public void GetAllProducts()
        {
            List<Product> products = productBLL.GetAllProducts();
            if (products == null)
            {
                Console.WriteLine("Not found.");
            }
            else
            {
                foreach (Product product in products)
                {
                    Console.WriteLine(product);
                }
            }
        }
        public void UpDateProduct()
        {
            string productName = "";
            bool isDone = false;
            Console.Write("UpDateProduct id?: ");
            int id = int.Parse(Console.ReadLine());
            Product oldItem = productBLL.GetByID(id);
            if (oldItem == default(Product))
            {
                Console.WriteLine("Not found.");
            }
            else
            {
                Console.Write(oldItem.ProductName + " Is it Ok?(y/n): ");
                if ("y" == Console.ReadLine())
                {
                    productName = oldItem.ProductName;
                }
                else
                {
                    Console.Write("Enter new value: ");
                    productName = Console.ReadLine();
                }
                Console.Write(productName + " Is it Ok?(y/n): ");
                if ("y" == Console.ReadLine())
                {
                    isDone = productBLL.UpDateProduct(oldItem, productName);
                    if (isDone)
                    {
                        Console.WriteLine("Updated.");
                    }
                    else
                    {
                        Console.WriteLine("Error.");
                    }
                }
                else
                {
                    Console.WriteLine("Not updated.");
                }
            }
        }

        public void DeleteProduct()
        {
            bool isDone = false;
            Console.Write("DeleteProduct id?: ");
            int id = int.Parse(Console.ReadLine());
            Product result = productBLL.GetByID(id);

            if (result == default(Product))
            {
                Console.WriteLine("Not found.");
            }
            else
            {
                isDone = productBLL.DeleteProduct(result);
                if (isDone)
                {
                    Console.WriteLine("Delited.");
                }
                else
                {
                    Console.WriteLine("Error.");
                }
            }
        }
    }
}
