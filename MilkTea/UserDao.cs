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
        public UserDao() { }

        public string CheckLogin(string UserID,string Password)
        {
            string role = "fail";
            string sql = "Select Role From Users Where UserID = @User and Password = @Password";
            SqlConnection cnn = DBConnection.GetConnection();
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
                        role = reader.GetString(0); 
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
