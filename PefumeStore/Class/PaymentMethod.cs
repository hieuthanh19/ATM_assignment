using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeStoreManagement.Class
{
    class PaymentMethod
    {
        public int payment_id { get; set; }
        public string payment_name { get; set; }
        public string payment_description { get; set; }
        public int payment_status { get; set; }
    }
}
