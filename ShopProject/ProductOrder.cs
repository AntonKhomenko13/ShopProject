using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject
{
    internal class ProductOrder
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int OrderID { get; set; }
        public int Quantity { get; set; }

        public ProductOrder(int id, int productId, int orderId, int quantity)
        {
            ID = id;
            ProductID = productId;
            OrderID = orderId;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return String.Format(ID + " " + ProductID + " " + OrderID + " " + Quantity);
        }

    }
}
