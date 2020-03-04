using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeStoreManagement.Class
{
    class Brand
    {
        public int brand_id { get; set; }
        public string brand_name { get; set; }
        public int country_id { get; set; }
        public DateTime brand_createdAt { get; set; }
        public int brand_status { get; set; }
    }
}
