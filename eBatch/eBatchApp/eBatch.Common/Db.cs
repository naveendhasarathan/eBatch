using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace eBatch.Common
{
    public static class Db
    {

        public static IDbConnection Connection()
        {
            return (IDbConnection)new SqlConnection(ConfigurationManager.ConnectionStrings["eBatchDBConnection"].ConnectionString);
        }

        public static void Save(CommandDefinition cmd)
        {
            Connection().Execute(cmd);
        }

        public static List<T> Fetch<T>(string spName, List<Tuple<string, string>> param = null)
        {
            var dynParam = new DynamicParameters();

            if (!(param is null))
            {
                foreach (var p in param)
                {
                    dynParam.Add(p.Item1, p.Item2);
                }
            }
            return (List<T>)Connection().Query<T>(spName, dynParam, commandType: CommandType.StoredProcedure);
        }

        public static List<T> Fetch<T>(string spName, DynamicParameters dynParam)
        {
            return (List<T>)Connection().Query<T>(spName, dynParam, commandType: CommandType.StoredProcedure);
        }

    }
}
