using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTea
{
    public class MilkTeaDTO
    {
        public string MilkTeaID { get; set; }
        public string MilkTeaName { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public string Category { get; set; }
        
        //public CategoryDTO categoryDTO { get; set; }
        //public MilkTeaDTO(string milkTeaID, string milkTeaName, int quantity,float price,string category, CategoryDTO dto)
        //{
        //    MilkTeaID = milkTeaID;
        //    MilkTeaName = milkTeaName;
        //    Quantity = quantity;
        //    Price = price;
        //    Category = category;
        //    categoryDTO = dto;
        //}
    }
}
