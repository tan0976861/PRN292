using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRN292.DTO;
using PRN292.DB;
using System.Data.SqlClient;
using System.Data;

namespace PRN292.DAO
{
    public class BillDAO
    {
        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();
            string sql = "select CategoryID,CategoryName from Category";
            SqlConnection conn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //CategoryDTO dto = new CategoryDTO
                    //{
                    //    CategoryID = reader.GetString(0),
                    //    CategoryName = reader.GetString(1)
                    //};
                    string CategoryID = reader.GetString(0);
                    string CategoryName = reader.GetString(1);
                    list.Add(new Category(CategoryID, CategoryName));
                }
            }
            conn.Close();
            return list;
        }

        public DataTable getTea(string TeaName)
        {
            SqlConnection cnn = DBConnection.GetConnection();
            string SQL = "Select MilkTeaID,Quantity,Price from MilkTeas where MilkTeaName= @TeaName";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@TeaName", TeaName);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtMilkTea = new DataTable();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                da.Fill(dtMilkTea);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
            return dtMilkTea;
        }
        public int InsertBill(Bill dto)
        {
            string sql = "insert Bill values(@TimeOfCreate,@SumOfMoney,@Discount,@Pay,@Balance) select @@identity";
            SqlConnection conn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TimeOfCreate", dto.TimeOfCreate);
            cmd.Parameters.AddWithValue("@SumOfMoney", dto.SumOfMoney);
            cmd.Parameters.AddWithValue("@Discount", dto.Discount);
            cmd.Parameters.AddWithValue("@Pay", dto.Pay);
            cmd.Parameters.AddWithValue("@Balance", dto.Balance);
            cmd.CommandType = CommandType.Text;


            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            int lastid = int.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
            return lastid;


        }
        public DataTable getListBillByDate(string firstday, string secondday)
        {
            SqlConnection conn = DBConnection.GetConnection();
            string sql = "Select BillID as [STT Hóa Đơn], SumOfMoney as [Tổng Tiền],TimeOfCreate as [Ngày tạo HD],Discount as [Giảm Giá(%)] from Bill where TimeOfCreate >= @firstday and TimeOfCreate <= @seconday ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@firstday", firstday);
            cmd.Parameters.AddWithValue("@seconday", secondday);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtBill = new DataTable();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                da.Fill(dtBill);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtBill;
            
        }

    }
}
