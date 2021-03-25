using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRN292.DAO;
using PRN292.DTO;
namespace PRN292.BUS
{
    public class BillBUS
    {
        BillDAO dao = new BillDAO();
        public List<Category> GetListCategory()
        {
            return dao.GetListCategory();
        }

        public DataTable getTea(string TeaName)
        {
            return dao.getTea(TeaName);
        }
        public int InsertBill(Bill dto)
        {
            return dao.InsertBill(dto);
        }
        public DataTable getListBillByDate(string firstday, string secondday)
        {
            return dao.getListBillByDate(firstday, secondday);
        }
    }
}
