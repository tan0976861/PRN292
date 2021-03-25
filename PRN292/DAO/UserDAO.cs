using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRN292.DB;

namespace PRN292.DAO
{
    public class UserDao
    {
        public string Login(string UserID, string Password)
        {
            string result = "fail";
            string sql = "Select UserID From Users Where UserID = @User and Password = @Password";
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
                        result = reader.GetString(0);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            cnn.Close();
            return result;
        }
    }      
}
