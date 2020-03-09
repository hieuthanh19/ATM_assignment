using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeStoreManagement.Class
{
    class Category
    {
        public int category_id { get; set; }
        public string category_name { get; set; }
        public string category_status { get; set; }


        public int getCategoryIdFromProductId(int productId)
        {
            
            int cId = -1;
            PefumeStore.Connection con = new PefumeStore.Connection();
            using (SqlConnection sqlCon = con.sqlConnection())
            {
                SqlCommand command = new SqlCommand("select * from product where product_id = @productId", sqlCon);
                command.Parameters.AddWithValue("productId", productId);

                sqlCon.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cId = int.Parse(reader["category_id"].ToString());
                    }
                    sqlCon.Close();
                }
                return cId;
            }
        }
    }

    
}
