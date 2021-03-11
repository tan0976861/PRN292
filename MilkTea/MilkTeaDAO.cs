using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTea
{
    public class MilkTeaDAO
    {
        public MilkTeaDAO() { 
        }
        public List<MilkTeaDTO> GetListMilkTea()
        {
            List<MilkTeaDTO> list = new List<MilkTeaDTO>();
            string sql = "select mt.MilkTeaID,mt.MilkTeaName,mt.Quantity,mt.Price,ct.CategoryName From MilkTeas as mt " +
                "left join Category as ct on mt.CategoryID = mt.CategoryID";
            SqlConnection conn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader ra = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if(ra.HasRows)
            {
                while(ra.Read())
                {
                    MilkTeaDTO dto = new MilkTeaDTO
                    {
                        MilkTeaID = ra.GetString(0),
                        MilkTeaName = ra.GetString(1),
                        Quantity = ra.GetInt32(2),
                        Price = (float)ra.GetDouble(3),
                        Category = ra.GetString(4)
                    };
                    list.Add(dto);
                }
            }
            conn.Close();
            return list;
        }
        /*public MilkTeaDTO FindProduct(int ID)
        {
            MilkTeaDTO milkTea = null;
            string sql = "select * from MilkTeas where MilkTeaID=@ID";
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
                        milkTea = new MilkTeaDTO();
                        milkTea.MilkTeaID = reader.GetString(0);
                        milkTea.MilkTeaName = reader.GetString(1);
                        milkTea.Quantity = reader.GetInt32(2);
                      *//*  milkTea.Price = (float)reader.GetDecimal(3);*//*
                        milkTea.Category = reader.GetString(4);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            cnn.Close();

            return milkTea;
        }
        public bool AddNewMilkTea(MilkTeaDTO dto)
        {
            bool result;
            string sql = "insert MilkTeas values (@ID , @Name, @Quantity, @Price, @Category)";
            SqlConnection cnn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@ID", dto.MilkTeaID);
            cmd.Parameters.AddWithValue("@Name", dto.MilkTeaName);
            cmd.Parameters.AddWithValue("@Quantity", dto.Quantity);
            cmd.Parameters.AddWithValue("@Price", dto.Price);
            cmd.Parameters.AddWithValue("@Category", dto.Category);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
            cnn.Close();
            return result;
        }*/
        //public List<CategoryDTO> GetListCategory() { }
    }
}
