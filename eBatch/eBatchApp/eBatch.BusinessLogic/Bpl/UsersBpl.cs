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
    }
}
