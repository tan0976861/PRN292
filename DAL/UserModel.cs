using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserModel
    {
        private DBContext db = null;
        public UserModel()
        {
            db = new DBContext();
        }

        public tblUsers checkLogin(string userID, string password)
        {
            tblUsers tblUser = new tblUsers();
            tblUsers a = db.tblUsers.Find(userID);
            tblUsers b = db.tblUsers.Find(password);
            if (a.Equals(tblUser.UserID))
            {
                return tblUser;
            }
            else
            {
                return null;
            }
        }

    }
}
