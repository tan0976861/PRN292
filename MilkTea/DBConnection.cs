using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTea
{
    class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            string conStr = @"Data Source=SE140290\SQLEXPRESS;Initial Catalog=MilkTea;Persist Security Info=True;User ID=sa; Password= 1009";
            SqlConnection conn = new SqlConnection(conStr);
            return conn;
        }
    }
}
