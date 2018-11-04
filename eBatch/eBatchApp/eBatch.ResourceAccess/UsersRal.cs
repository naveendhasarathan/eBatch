using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using eBatch.BusinessEntities.Models;
using eBatch.Common;
using System.Data;
using eBatch.BusinessEntities.Enums;

namespace eBatch.ResourceAccess
{
    public class UsersRal
    {
        /// <summary>
        /// To get Users
        /// </summary>
        /// <returns>List of Users</returns>
        public List<User> GetUsers()
        {
            return Db.Fetch<User>(SPEnum.spGetUsers.ToString());
        }

        /// <summary>
        /// To Save User details
        /// </summary>
        /// <param name="user">User.</param>
        public void SaveUsers(User user)
        {
            var dynParams = new DynamicParameters();
            dynParams.Add("@UserId", user.id);
            dynParams.Add("@UserName", user.username);
            dynParams.Add("@RoleId", user.userRole.RoleId);
            dynParams.Add("@DifficultyLevel", user.difficulty_level);
            dynParams.Add("@Active", user.active);
            CommandDefinition cmd = new CommandDefinition(SPEnum.spSaveUsers.ToString(), dynParams, commandType: CommandType.StoredProcedure);
            Db.Save(cmd);
        }
    }
}
