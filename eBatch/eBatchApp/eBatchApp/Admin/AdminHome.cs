using eBatch.BusinessLogic.Bpl;
using eBatch.Theme.Purple;
using eBatchApp.Common;
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
            tbAdminModule.SelectedTab = tbUser;
            tbAdminModule.Location = new Point(0, 0);
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

        private void tbSupplier_Click(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            dgvSuppliers.DataSource = new UsersBpl().GetUsers();
        }

        private void tbSupplier_FontChanged(object sender, EventArgs e)
        {

        }

        private void tbSupplier_Enter(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void tbRoleMapping_Enter(object sender, EventArgs e)
        {
            LoadRoleMapping();
        }

        private void LoadRoleMapping()
        {
            cbUsers.DataSource = new UsersBpl().GetUsers();
            cbUsers.ValueMember = "id";
            cbUsers.DisplayMember = "username";

            dgvUserRoleMapping.DataSource = Utility.LoadCode(eBatch.BusinessEntities.Enums.CodeEnum.Module);
        }

        private void dgvUserRoleMapping_Enter(object sender, EventArgs e)
        {
          
        }
    }
}
