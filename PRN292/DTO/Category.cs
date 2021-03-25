using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292.DTO
{
    public class Category
    {
        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
        public override string ToString()
        {
            return CategoryID + "-" + CategoryName;
        }
        public Category(string categoryID,string categoryName)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
        }
    }
}
