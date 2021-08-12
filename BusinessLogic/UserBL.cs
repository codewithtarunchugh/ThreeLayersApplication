using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccess;


namespace BusinessLogic
{
    public class UserBL
    {
        public UserBL()
        {
        }
        public CustomBO AddUser(UserBO objUserBo)
        {
            return new UserDAL().AddUser(objUserBo);
        }
    }
}
