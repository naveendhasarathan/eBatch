using eBatch.BusinessEntities.Enums;
using eBatch.BusinessLogic.Bpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBatchApp.Common
{
    public static class Utility
    {
        public static void LoadCode(ComboBox cb, CodeEnum code)
        {
            var difficultyLevel = new CodeBpl().GetCode(code);
            cb.DataSource = difficultyLevel.Select(x => new { id = x.id, codevalue = x.CodeValue }).ToList();
            cb.DisplayMember = "Codevalue";
            cb.ValueMember = "id";
        }

        public static int toInt(this object value)
        {
            return Convert.ToInt32(value);
        }

        internal static void Validate()
        {
            ///... Common validation has to be coded.
        }
    }
}
