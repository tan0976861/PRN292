using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTea
{
    public class User
    {
        public string UserID { get; set; }
        public string Password { get; set; }
        public string RoleID { get; set; }
    }
    public class Product
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string Price { get; set; }

    }
}
