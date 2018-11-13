using eBatch.BusinessEntities.Enums;
using eBatch.BusinessLogic.Bpl;
using eBatch.Theme.Purple;
using System;
using eBatchApp.Common;
using BL = eBatch.BusinessEntities.Models;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

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
            Utility.LoadCodeToCB(cbDifficultyLevel, CodeEnum.DifficultyLevel);
            Utility.LoadCodeToCB(cbRole, CodeEnum.UserRole);
            List<string> lstUserName = new List<string>();
            lstUserName.AddRange(new string[] { "Apple", "Alexa", "Aprocot", "Alladin", "box", "boost", "boolean" });


            AutoCompleteStringCollection aa = new AutoCompleteStringCollection();
            aa.AddRange(lstUserName.ToArray());

            cbUserName.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbUserName.AutoCompleteCustomSource = aa;
            cbUserName.Items.AddRange(lstUserName.ToArray());
            cbUserName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cbUserName.DropDownStyle = ComboBoxStyle.DropDownList;
            // cbUserName.DroppedDown = true;


            //  cbUserName.DataSource =  lstUserName;

            //Only the value AutoCompleteMode.None can be used when DropDownStyle is ComboBoxStyle.DropDownList and AutoCompleteSource is not AutoCompleteSource.ListItems.


            FancyStyleToggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Fancy;
            FancyStyleToggleSwitch.Size = new Size(100, 30);
            FancyStyleToggleSwitch.OnText = "Active";
            //FancyStyleToggleSwitch.OnFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold);
            FancyStyleToggleSwitch.OnForeColor = Color.White;
            FancyStyleToggleSwitch.OffText = "InActive";
            //FancyStyleToggleSwitch.OffFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold);
            FancyStyleToggleSwitch.OffForeColor = Color.White;
           // FancyStyleToggleSwitch.ButtonImage = Resources.handle;

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

        private void eButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hey");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.FancyStyleToggleSwitch.Checked.ToString());
        }

        private void cbUserName_KeyDown(object sender, KeyEventArgs e)
        {
           // cbUserName.DroppedDown = false;
        }
    }
}
