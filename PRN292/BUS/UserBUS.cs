using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PRN292.DAO;
using System.Threading.Tasks;

namespace PRN292.BUS
{
   public  class UserBUS
    {
        UserDao userDAO = new UserDao();

        public string Login(string UserID, string Password)
        {
            return userDAO.Login(UserID, Password);
        }

    }
}
