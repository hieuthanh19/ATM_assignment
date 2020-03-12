using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        /// <summary>
        /// Get brand ID from Product ID
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public int getBrandIdFromProductId(int productId)
        {
            
            int bId = -1;
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
                        bId = int.Parse(reader["brand_id"].ToString());
                    }
                    sqlCon.Close();
                }
                return bId;
            }
        }
    }
}
