using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess
{
    public class UserDAL
    {
        private UserDBEntities objUserDBEntities;
        public UserDAL()
        {
            objUserDBEntities = new UserDBEntities();
        }
        public CustomBO AddUser(UserBO objUserBo)
        {
            CustomBO objCustomBO = new CustomBO();
            User objUser = new User()
            {
                UserAddress = objUserBo.UserAddress,
                UserEmail = objUserBo.UserEmail,
                UserMobile = objUserBo.UserPhone,
                UserName = objUserBo.UserName
            };
            objUserDBEntities.Users.Add(objUser);
            int returnValue = objUserDBEntities.SaveChanges();
            if (returnValue > 0)
            {
                objCustomBO.CustomMessage = "Data Successfully Added.";
                objCustomBO.CustomMessageNumber = returnValue;
            }
            else
            {
                objCustomBO.CustomMessage = "There is some problem to add user.";
                objCustomBO.CustomMessageNumber = returnValue;
            }
            return objCustomBO;
        }
    }
}
