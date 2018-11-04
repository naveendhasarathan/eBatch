using eBatch.BusinessLogic.Bpl;
using eBatch.Theme.Purple;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL = eBatch.BusinessEntities.Models;

namespace eBatchApp.Admin
{
    public partial class AdminHome : eForm
    {
        public AdminHome()
        {
            InitializeComponent();
            dgvUsers.AutoGenerateColumns = false;
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        public void LoadUsers()
        {
            dgvUsers.DataSource = new UsersBpl().GetUsers();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            using (AddUser aduser = new AddUser())
            {
                if (aduser.ShowDialog() != DialogResult.Cancel)
                {
                    LoadUsers();
                }
            }
        }
    }
}
