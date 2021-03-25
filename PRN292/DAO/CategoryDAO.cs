using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRN292.DTO;
using PRN292.DB;
namespace PRN292.DAO
{
    public class CategoryDAO
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
                    string CategoryID = reader.GetString(0);
                    string CategoryName = reader.GetString(1);
                    list.Add(new Category(CategoryID, CategoryName));
                }
            }
            conn.Close();
            return list;
        }
        public bool Add(Category dto)
        {
            bool result;
            string sql = "insert Category values (@ID , @Name)";
            SqlConnection cnn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@ID", dto.CategoryID);
            cmd.Parameters.AddWithValue("@Name", dto.CategoryName);

            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch
            {
                return false;
            }
            cnn.Close();
            return result;
        }


        public bool Update(Category dto)
        {
            bool check = false;
            string sql = "Update Category Set CategoryName = @Name Where CategoreID = @ID";
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID", dto.CategoryID);
            cmd.Parameters.AddWithValue("@Name", dto.CategoryName);

            check = cmd.ExecuteNonQuery() > 0;
            conn.Close();
            return check;
        }

        public bool Delete(string id)
        {
            bool check = false;
            string sql = "Delete Category Where CategoryID = @ID";
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID", id);
            check = cmd.ExecuteNonQuery() > 0;
            conn.Close();
            return check;
        }
        public Category FindCategory(string ID)
        {
            Category category = null;
            string sql = "select * from Category where CategoryID=@ID";
            SqlConnection cnn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@ID", ID);
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
                        
                        string CategoryID = reader.GetString(0);
                        string CategoryName = reader.GetString(1);
                        category = new Category(CategoryID,CategoryName);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            cnn.Close();

            return category;
        }
    }
}
