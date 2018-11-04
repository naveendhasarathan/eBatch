using eBatch.Theme.Purple;
using eBatchApp.Admin;
using eBatchApp.DataEntry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBatchApp.Common
{
    public partial class Login : eForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();


           // InvoiceEntry inv = new InvoiceEntry();
          //  inv.Show();

            Home home = new Home();
            home.Show();

            //AdminHome ah = new AdminHome();
            //ah.Show();
        }
    }
}
