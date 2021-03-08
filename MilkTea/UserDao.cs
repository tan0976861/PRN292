using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace MilkTea
{
    public class UserDao
    {
        string StrConnection;
        public UserDao()
        {
            StrConnection = GetConnectionString();
        }
        public string GetConnectionString()
        {
            string strConnection = @"Data Source=DESKTOP-1Q0I8B0\HOANGTG;Initial Catalog=MilkTea;Persist Security Info=True;User ID=sa; Password=026042855";
            return strConnection;
        }
        public string CheckLogin(string UserID,string Password)
        {
            string role = "Failed";
            string sql = "Select RoleID From tblUsers Where UserID = @ID and Password = @Password";
            SqlConnection cnn = new SqlConnection(StrConnection);
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@ID", UserID);
            cmd.Parameters.AddWithValue("@Password", Password);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        User user = new User();
                        role = reader.GetString(1);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            cnn.Close();
            return role;
        }
    }
}
