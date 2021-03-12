using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTea
{
    public class CategoryDTO
    {
        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
        public override string ToString()
        {
            return CategoryID + "-" + CategoryName;
        }
        public CategoryDTO(string categoryID,string categoryName)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
        }
    }
}
