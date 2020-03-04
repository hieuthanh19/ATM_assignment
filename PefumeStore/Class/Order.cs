using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeStoreManagement.Class
{
    class Order
    {
        public int order_id { get; set; }
        public int user_id { get; set; }
        public int order_paymentStatus { get; set; }
        public int order_handledBy { get; set; }
        public int order_status { get; set; }
        public int order_paymentMethod { get; set; }
        public double order_totalCost { get; set; }
        public string order_receiverName { get; set; }
        public string order_receiverAddress { get; set; }
        public string order_receiverPhone { get; set; }
        public string order_receiverEmail { get; set; }
        public int deliveryMethod_id { get; set; }
        public int order_deliveryStatus { get; set; }
        public DateTime order_createdAt { get; set; }
        public DateTime order_updatedAt { get; set; }
        public DateTime order_delveredAt { get; set; }
    }
}
