using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRN292.DAO;
using PRN292.DTO;


namespace PRN292.BUS
{
    
    
    public class MilkTeaBUS
    {
        MilkTeaDAO dao = new MilkTeaDAO();

        public List<MilkTea> GetListMilkTea()
        {
            return dao.GetListMilkTea();
        }
        public MilkTea FindProduct(string ID)
        {
            return dao.FindProduct(ID);

        }

        public bool AddNewMilkTea(MilkTea dto)
        {
            return dao.AddNewMilkTea(dto);
        }


        public bool Update(MilkTea dto)
        {
            return dao.Update(dto);
        }

        public bool Delete(string id)
        {
            return dao.Delete(id);
        }

        public string getCategoryIDByMilkTeaID(string milkID)
        {
            return dao.getCategoryIDByMilkTeaID(milkID);
        }
        public List<MilkTea> SearchMilkTea(string milkteaID)
        {
            return dao.SearchMilkTea(milkteaID);
        }

    }
}
