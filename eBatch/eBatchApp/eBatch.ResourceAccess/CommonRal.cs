using eBatch.BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBatch.Common;
using eBatch.BusinessEntities.Enums;

namespace eBatch.ResourceAccess
{
    public class CommonRal
    {
        public List<Codevalue> GetCode(CodeEnum code)
        {
            List<Tuple<string, string>> dynParams = new List<Tuple<string, string>>();
            dynParams.Add(new Tuple<string, string>("@codecategory", code.ToString()));
            return Db.Fetch<Codevalue>("spGetCodes",dynParams);
        }

    }
}
