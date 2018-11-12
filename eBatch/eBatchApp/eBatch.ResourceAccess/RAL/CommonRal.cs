﻿using eBatch.BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBatch.Common;
using eBatch.BusinessEntities.Enums;
using Dapper;

namespace eBatch.ResourceAccess
{
    public class CommonRal
    {
        public List<Codevalue> GetCode(CodeEnum code)
        {
            var dynParams = new DynamicParameters(new
            {
                codecategory = code.ToString(),
            });

            return Db.Fetch<Codevalue>(SPEnum.spGetCodes.ToString(),dynParams);
        }

        public List<Audit> GetAudit(string auditType)
        {
            var dynParams = new DynamicParameters(new
            {
                tablename = "tblUsers",
            });

            return Db.Fetch<Audit>(SPEnum.spGetAudtiTrail.ToString(), dynParams);
        }
    }
}
