﻿using System;
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
            
            string sql = "select mt.MilkTeaID,mt.MilkTeaName,mt.Quantity,mt.Price,ct.CategoryName,mt.CategoryID,mt.Image " +
                "From MilkTeas as mt,Category as ct Where ct.CategoryID = mt.CategoryID";
            SqlConnection conn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader read = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if(read.HasRows)
            {
                while(read.Read())
                {
                    MilkTeaDTO milkTeaDTO = new MilkTeaDTO()
                    {
                        MilkTeaID = read.GetString(0),
                        MilkTeaName = read.GetString(1),
                        Quantity = read.GetInt32(2),
                        Price = (float)read.GetDouble(3),
                        Category = read.GetString(5),
                        Image = read.GetString(6)
                    };
                //string M  ilkTeaID = read.GetString(0);
                //    string MilkTeaName = read.GetString(1);
                //    int Quantity = read.GetInt32(2);
                //    float Price = (float)read.GetDouble(3);
                //    string Category = read.GetString(4);
                    //CategoryDTO categoryDTO = null;
                    //foreach (CategoryDTO dto in categoryDTOs)
                    //{
                    //    if (dto.CategoryID.Equals(Category)) categoryDTO = dto;
                    //}
                    //MilkTeaDTO milkTeaDTO = new MilkTeaDTO(MilkTeaID, MilkTeaName, Quantity, Price, Category, categoryDTO);
                    list.Add(milkTeaDTO);
                }
            }
            conn.Close();
            return list;
        }
        public MilkTeaDTO FindProduct(string ID)
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
                        milkTea.Price = (float)reader.GetDouble(2);
                        milkTea.Quantity = reader.GetInt32(3);
                        milkTea.Category = reader.GetString(4);
                        milkTea.Image = reader.GetString(5);
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
            string sql = "insert MilkTeas values (@ID , @Name, @Quantity, @Price, @Category, @Image)";
            SqlConnection cnn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@ID", dto.MilkTeaID);
            cmd.Parameters.AddWithValue("@Name", dto.MilkTeaName);
            cmd.Parameters.AddWithValue("@Quantity", dto.Quantity);
            cmd.Parameters.AddWithValue("@Price", dto.Price);
            cmd.Parameters.AddWithValue("@Category", dto.Category);
            cmd.Parameters.AddWithValue("@Image", dto.Image);
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
        }
        public List<CategoryDTO> GetListCategory() {
            List<CategoryDTO> list = new List<CategoryDTO>();
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
                    list.Add(new CategoryDTO(CategoryID, CategoryName));
                }
            }
            conn.Close();
            return list;
        }

        public bool Update(MilkTeaDTO dto)
        {
            bool check = false;
            string sql = "Update MilkTeas Set MilkTeaName = @Name, Quantity = @Quantity, Price = @Price, CategoryID = @Category,  Image = @Image Where MilkTeaID = @ID";
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID", dto.MilkTeaID);
            cmd.Parameters.AddWithValue("@Name", dto.MilkTeaName);
            cmd.Parameters.AddWithValue("@Quantity", dto.Quantity);
            cmd.Parameters.AddWithValue("@Price", dto.Price);
            cmd.Parameters.AddWithValue("@Category", dto.Category);
            cmd.Parameters.AddWithValue("@Image", dto.Image);
            check = cmd.ExecuteNonQuery() > 0;
            conn.Close();
            return check;
        }

        public bool Delete(string id)
        {
            bool check = false;
            string sql = "Delete MilkTeas Where MilkTeaID = @ID";
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID", id);
            check = cmd.ExecuteNonQuery() > 0;
            conn.Close();
            return check;
        }

        public string getCategoryIDByMilkTeaID(string milkID)
        {
            string result = null;
            string sql = "Select CategoryID from MilkTeas where MilkTeaID = @ID";
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID", milkID);
            SqlDataReader ra = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if(ra.HasRows)
            {
                if(ra.Read())
                {
                    result = ra["CategoryID"].ToString();
                }
            }
            conn.Close();
            return result;
        }
    }
}
