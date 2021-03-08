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
        public UserDao()
        {
        }
        string StrConnection = "server=SE140290\\SQLEXPRESS;database=MilkTea;uid=sa;pwd=1009";
        public User CheckLogin(string UserID,string Password)
        {
            User user = null;
            string sql = "Select RoleID From tblUsers Where UserID = @U and Password = @P";
            SqlConnection cnn = new SqlConnection(StrConnection);
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@U", UserID);
            cmd.Parameters.AddWithValue("@P", Password);
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        user = new User();
                        user.RoleID = reader.GetString(0);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            cnn.Close();
            return user;
        }
    }
}
