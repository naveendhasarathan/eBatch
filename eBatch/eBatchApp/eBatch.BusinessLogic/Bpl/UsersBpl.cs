using eBatch.BusinessEntities.Models;
using eBatch.ResourceAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBatch.BusinessLogic.Bpl
{
    public class UsersBpl
    {
        public List<User> GetUsers()
        {
            var res= new UsersRal().GetUsers();
            var resdt = res.ToDataTable();
            return res;
        }

        public DataTable GetUsersDT()
        {
            return new UsersRal().GetUsersDT().ToDataTable();
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
