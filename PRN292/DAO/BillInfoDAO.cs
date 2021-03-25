using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRN292.DTO;
using PRN292.DB;
namespace PRN292.DAO
{
    public class BillInfoDAO
    {
        public bool InsertBillInfo(BillInfo dto)
        {
            bool result;
            string sql = "insert BillInfo values(@BillID,@MilkTeaID,@Quantity,@Price,@Money)";
            SqlConnection conn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            // cmd.Parameters.AddWithValue("@BillDetailsID", dto.BillDetailsID);
            cmd.Parameters.AddWithValue("@BillID", dto.BillID);
            cmd.Parameters.AddWithValue("@MilkTeaID", dto.MilkTeaID);
            cmd.Parameters.AddWithValue("@Quantity", dto.Quantity);
            cmd.Parameters.AddWithValue("@Price", dto.Price);
            cmd.Parameters.AddWithValue("@Money", dto.Money);
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            result = cmd.ExecuteNonQuery() > 0;
            conn.Close();
            return result;

        }
    }
}
