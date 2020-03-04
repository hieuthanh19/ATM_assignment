using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeStoreManagement.Class
{
    class Product
    {
        public int product_id { get; set; }
        public string product_name { get; set; }
        public double product_volumne { get; set; }
        public int product_quantity { get; set; }
        public int category_id { get; set; }
        public int brand_id { get; set; }
        public double product_originalPrice { get; set; }
        public double product_currentPrice { get; set; }
        public string product_description { get; set; }
        public int product_status { get; set; }
        public DateTime product_createdAt { get; set; }
        public int product_createdBy { get; set; }
        public int product_updatedAt { get; set; }
        public int product_updatedBy { get; set; }

    }
}
