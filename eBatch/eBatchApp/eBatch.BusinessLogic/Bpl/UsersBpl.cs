using eBatch.BusinessEntities.Models;
using eBatch.ResourceAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBatch.BusinessLogic.Bpl
{
    public class UsersBpl
    {
        public List<User> GetUsers()
        {
            return new UsersRal().GetUsers();
        }

        public void SaveUsers(User user)
        {
            new UsersRal().SaveUsers(user);
        }

        public List<RoleMapping> GetUserRoleMapping(int userId)
        {
            return new UsersRal().GetUserRoleMapping(userId);
        }

        public void SaveUserRoleMapping(int UserId,List<RoleMapping> lstRoleMapping)
        {
          var dt=  lstRoleMapping.ToDataTable();
            new UsersRal().SaveUserRoleMapping(UserId,dt);
        }
    }
}
