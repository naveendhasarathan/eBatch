using eBatch.BusinessEntities.Enums;
using eBatch.BusinessLogic.Bpl;
using eBatch.Theme.Purple;
using System;
using eBatchApp.Common;
using BL = eBatch.BusinessEntities.Models;

namespace eBatchApp.Admin
{
    public partial class AddUser : eFormPopup
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            Utility.LoadCode(cbDifficultyLevel, CodeEnum.DifficultyLevel);
            Utility.LoadCode(cbRole, CodeEnum.UserRole);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utility.Validate();
            BL.User user = new BL.User()
            {
                username = txtUserName.Text,
                difficulty_level = cbDifficultyLevel.SelectedValue.toInt(),
                userRole = new BL.Role() { RoleId = cbRole.SelectedValue.toInt() },
                active = checkBox1.Checked
            };

            new UsersBpl().SaveUsers(user);
            this.Close();
        }
    }
}
