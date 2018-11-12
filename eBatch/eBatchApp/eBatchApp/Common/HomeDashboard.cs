using eBatch.Theme.Purple;
using eBatchApp.Admin;
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
    public partial class HomeDashboard : eForm
    {
        Form _pForm = null;
        public HomeDashboard()
        {
            InitializeComponent();
        }
        public HomeDashboard(Form pForm)
        {
            InitializeComponent();
            _pForm = pForm;
        }

        private void HomeDashboard_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "eBatch Application.";
        }

        private void AdminTile_Click(object sender, EventArgs e)
        {

            AdminHome frmAdmin = new AdminHome();
            frmAdmin.MdiParent = _pForm;
            frmAdmin.WindowState = FormWindowState.Maximized;
            frmAdmin.Show();
            this.Hide();
            _pForm.Controls["panel2"].Visible = true;
        }
    }
}
