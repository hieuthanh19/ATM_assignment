using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;  //add from references

namespace PefumeStore
{
    class Connection
    {
        public SqlConnection sqlConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["PefumeStore.Properties.Settings.Perfume_StoreConnectionString"].ConnectionString);  
            //see connection string in app.config in solution tree
        }
    }
}
