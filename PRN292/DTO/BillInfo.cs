using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292.DTO
{
    public class BillInfo
    {
        public int BillID { get; set; }
        public string MilkTeaID { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public float Money { get; set; }
    }
}
