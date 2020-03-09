using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeStoreManagement.Class
{
    class User
    {
        public int user_id { get; set; }
        public string user_username { get; set; }
        public string user_password { get; set; }
        public int user_status { get; set; }
        public int user_roleId { get; set; }
        public string user_fullName { get; set; }
        public string user_address { get; set; }
        public string user_phone { get; set; }
        public string user_email { get; set; }
        public string user_avatarPath { get; set; }
        public DateTime user_createAt { get; set; }

       
    }
}
