using PRN292.DTO;
using PRN292.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292.BUS
{
   public class BillInfoBUS
    {
        BillInfoDAO dao = new BillInfoDAO();
        public bool InsertBillInfo(BillInfo dto)
        {
            return dao.InsertBillInfo(dto);
        }

    }
}
