using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeStoreManagement.Class
{
    class OrderItem
    {
        public int order_id { get; set; }
        public int product_id { get; set; }
        public string  orderItem_quantity { get; set; }
        public double product_price { get; set; }
    }
}
