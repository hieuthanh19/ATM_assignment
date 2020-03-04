using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeStoreManagement.Class
{
    class User_role
    {
        public int role_id { get; set; }
        public string role_name { get; set; }
        //1: active 2: locked
        public int role_status { get; set; }
    }
}
