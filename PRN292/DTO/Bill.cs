using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292.DTO
{
    public class Bill
    {
        public int BillID { get; set; }
        public DateTime TimeOfCreate { get; set; }
        public double SumOfMoney { get; set; }
        public int Discount { get; set; }
        public double Pay { get; set; }
        public double Balance { get; set; }
    }
}
