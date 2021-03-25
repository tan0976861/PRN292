using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRN292.DAO;
using PRN292.DTO;
namespace PRN292.BUS
{
    public class CategoryBUS
    {
        CategoryDAO dao = new CategoryDAO();
        public List<Category> GetListCategory()
        {
            return dao.GetListCategory();
        }
        public bool Add(Category dto)
        {
            return dao.Add(dto);
        }

        public bool Update(Category dto)
        {
            return dao.Update(dto);
        }

        public bool Delete(string id)
        {
            return dao.Delete(id);
        }
        public Category FindCategory(string ID)
        {
            return dao.FindCategory(ID);
        }
    }
}
