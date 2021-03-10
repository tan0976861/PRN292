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
        string strConnection;
        public UserDao()
        {
            strConnection = getConnectionString();
        }

        public string getConnectionString()
        {
            string strConnection = @"Data Source=SE140290\SQLEXPRESS;Initial Catalog=MilkTea;Persist Security Info=True;User ID=sa; Password=1009";
            return strConnection;
        }
        public User CheckLogin(string UserID,string Password)
        {
            User user = null;
            string sql = "Select RoleID From tblUsers Where UserID = @User and Password = @Password";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@User", UserID);
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
