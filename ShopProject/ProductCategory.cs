using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject
{
    internal class ProductCategory : IID
    {
        public int ID { get; set; }

        public int ProductID { get; set; }

        public int CategoryID { get; set; }

        public ProductCategory(int productID, int categoryID)
        {
            ProductID = productID;
            CategoryID = categoryID;
        }

        public override string ToString()
        {
            return String.Format(ID + " " + ProductID + " " + CategoryID);
        }
    }
}
