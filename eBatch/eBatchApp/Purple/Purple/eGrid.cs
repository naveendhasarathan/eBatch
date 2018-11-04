using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBatch.Theme.Purple
{
    public class eGrid : System.Windows.Forms.DataGridView
    {
        public eGrid()
        {
            AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dock = System.Windows.Forms.DockStyle.Fill;
            Location = new System.Drawing.Point(3, 54);
            Size = new System.Drawing.Size(694, 272);
        }
    }
}
