using eBatch.BusinessLogic.Bpl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL=eBatch.BusinessEntities.Models;

namespace eBatchApp.Admin
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void btnADSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            pnlGrid.SendToBack();

            pnlDetails.BringToFront();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlDetails.SendToBack();
            pnlGrid.BringToFront();
        }

        private void gvDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {
            UsersBpl userBL = new UsersBpl();
            List<BL.User> users = userBL.GetUsers();
            dataGridView1.DataSource = users;
            
        }
    }
}
