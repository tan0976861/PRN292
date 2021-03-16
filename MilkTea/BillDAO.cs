using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTea
{
   public  class BillDAO
    {
        public BillDAO(){ }
        public List<CategoryDTO> GetListCategory()
        {
            List<CategoryDTO> list = new List<CategoryDTO>();
            string sql = "select CategoryID,CategoryName from Category";
            SqlConnection conn = DbConnection.GetConnection();
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
                    list.Add(new CategoryDTO(CategoryID, CategoryName));
                }
            }
            conn.Close();
            return list;
        }

        public DataTable getTea(string TeaName)
        {
            SqlConnection cnn = DbConnection.GetConnection();
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
        //public MilkTeaDTO FindTea(string name)
        //{
        //    SqlConnection conn = DbConnection.GetConnection();
        //    string SQL = " select * from MilTeas where MilkTeaName = @name";
            
        //}

    }
}
