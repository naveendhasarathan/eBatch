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
        int userId = 0;
        public AdminHome()
        {
            InitializeComponent();
            dgvUsers.AutoGenerateColumns = false;
            dgvSuppliers.AutoGenerateColumns = false;
            dgvUserRoleMapping.AutoGenerateColumns = false;
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
            LoadUserRoleCB();

            //if (!cbUsers.Focused) { return; }

            //dgvUserRoleMapping.DataSource = new UsersBpl().GetUserRoleMapping();
        }

        private void LoadUserRoleCB()
        {
            var users = new UsersBpl().GetUsers();
            users.Insert(0, new BL.User() { id = 0, username = "--Select User--" });
            cbUsers.DataSource = users;
            cbUsers.ValueMember = "id";
            cbUsers.DisplayMember = "username";
        }

        private void LoadUserRoleMappingList(int userId)
        {
           var result= new UsersBpl().GetUserRoleMapping(userId);
            dgvUserRoleMapping.DataSource = result;
        }

        private void dgvUserRoleMapping_Enter(object sender, EventArgs e)
        {

        }

        private void cbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (!cb.Focused) { return; }
             userId = (int)cb.SelectedValue;
            LoadUserRoleMappingList(userId);
        }

        private void dgvUserRoleMapping_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUserRoleSave_Click(object sender, EventArgs e)
        {
            var dt = (List<BL.RoleMapping>)dgvUserRoleMapping.DataSource;
            new UsersBpl().SaveUserRoleMapping(userId, dt);
        }

        private void btnAudit_Click(object sender, EventArgs e)
        {
            AdminAuditForm aaf = new AdminAuditForm();
            aaf.ShowDialog();
        }
    }
}
