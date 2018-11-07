using eBatch.Theme.Purple;

namespace eBatchApp.Admin
{
    partial class AdminHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbAdminModule = new MetroFramework.Controls.MetroTabControl();
            this.tbUser = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAudit = new eBatch.Theme.Purple.eNewButton();
            this.dgvUsers = new eBatch.Theme.Purple.eGrid();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userrole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.difficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddUser = new eBatch.Theme.Purple.eNewButton();
            this.tbSupplier = new System.Windows.Forms.TabPage();
            this.dgvSuppliers = new eBatch.Theme.Purple.eGrid();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DifficultyLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvalnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbRoleMapping = new System.Windows.Forms.TabPage();
            this.dgvUserRoleMapping = new eBatch.Theme.Purple.eGrid();
            this.pnlUserRole = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.eNewButton1 = new eBatch.Theme.Purple.eNewButton();
            this.btnUserRoleSave = new eBatch.Theme.Purple.eNewButton();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codevalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbAdminModule.SuspendLayout();
            this.tbUser.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tbSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.tbRoleMapping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRoleMapping)).BeginInit();
            this.pnlUserRole.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAdminModule
            // 
            this.tbAdminModule.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbAdminModule.Controls.Add(this.tbUser);
            this.tbAdminModule.Controls.Add(this.tbSupplier);
            this.tbAdminModule.Controls.Add(this.tbRoleMapping);
            this.tbAdminModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdminModule.Location = new System.Drawing.Point(0, 60);
            this.tbAdminModule.Name = "tbAdminModule";
            this.tbAdminModule.SelectedIndex = 2;
            this.tbAdminModule.Size = new System.Drawing.Size(708, 298);
            this.tbAdminModule.TabIndex = 0;
            this.tbAdminModule.UseSelectable = true;
            // 
            // tbUser
            // 
            this.tbUser.Controls.Add(this.panel2);
            this.tbUser.Controls.Add(this.dgvUsers);
            this.tbUser.Controls.Add(this.panel1);
            this.tbUser.Location = new System.Drawing.Point(4, 41);
            this.tbUser.Name = "tbUser";
            this.tbUser.Padding = new System.Windows.Forms.Padding(3);
            this.tbUser.Size = new System.Drawing.Size(700, 253);
            this.tbUser.TabIndex = 0;
            this.tbUser.Text = "User List";
            this.tbUser.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btnAudit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 51);
            this.panel2.TabIndex = 2;
            // 
            // btnAudit
            // 
            this.btnAudit.AutoSize = true;
            this.btnAudit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.btnAudit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAudit.DisplayFocus = true;
            this.btnAudit.ForeColor = System.Drawing.Color.White;
            this.btnAudit.Highlight = true;
            this.btnAudit.Location = new System.Drawing.Point(16, 8);
            this.btnAudit.Name = "btnAudit";
            this.btnAudit.Size = new System.Drawing.Size(100, 35);
            this.btnAudit.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnAudit.TabIndex = 9;
            this.btnAudit.Text = "Audit Trail";
            this.btnAudit.UseCustomBackColor = true;
            this.btnAudit.UseCustomForeColor = true;
            this.btnAudit.UseSelectable = true;
            this.btnAudit.UseStyleColors = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToOrderColumns = true;
            this.dgvUsers.AllowUserToResizeColumns = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvUsers.ColumnHeadersHeight = 40;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.userrole,
            this.difficulty,
            this.status,
            this.Action});
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.GridColor = System.Drawing.Color.Black;
            this.dgvUsers.Location = new System.Drawing.Point(3, 54);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.RowTemplate.DividerHeight = 1;
            this.dgvUsers.Size = new System.Drawing.Size(694, 196);
            this.dgvUsers.TabIndex = 1;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "User Name";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // userrole
            // 
            this.userrole.HeaderText = "User Role";
            this.userrole.Name = "userrole";
            this.userrole.ReadOnly = true;
            // 
            // difficulty
            // 
            this.difficulty.DataPropertyName = "difficulty_level";
            this.difficulty.HeaderText = "Difficulty Level";
            this.difficulty.Name = "difficulty";
            this.difficulty.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "active";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 51);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddUser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(524, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 51);
            this.panel3.TabIndex = 11;
            // 
            // btnAddUser
            // 
            this.btnAddUser.AutoSize = true;
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.DisplayFocus = true;
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Highlight = true;
            this.btnAddUser.Location = new System.Drawing.Point(56, 7);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(100, 35);
            this.btnAddUser.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnAddUser.TabIndex = 10;
            this.btnAddUser.Text = "Enable User";
            this.btnAddUser.UseCustomBackColor = true;
            this.btnAddUser.UseCustomForeColor = true;
            this.btnAddUser.UseSelectable = true;
            this.btnAddUser.UseStyleColors = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // tbSupplier
            // 
            this.tbSupplier.Controls.Add(this.dgvSuppliers);
            this.tbSupplier.Location = new System.Drawing.Point(4, 41);
            this.tbSupplier.Name = "tbSupplier";
            this.tbSupplier.Padding = new System.Windows.Forms.Padding(3);
            this.tbSupplier.Size = new System.Drawing.Size(700, 253);
            this.tbSupplier.TabIndex = 1;
            this.tbSupplier.Text = " Supplier List";
            this.tbSupplier.UseVisualStyleBackColor = true;
            this.tbSupplier.FontChanged += new System.EventHandler(this.tbSupplier_FontChanged);
            this.tbSupplier.Click += new System.EventHandler(this.tbSupplier_Click);
            this.tbSupplier.Enter += new System.EventHandler(this.tbSupplier_Enter);
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.AllowUserToOrderColumns = true;
            this.dgvSuppliers.AllowUserToResizeColumns = false;
            this.dgvSuppliers.AllowUserToResizeRows = false;
            this.dgvSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuppliers.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvSuppliers.ColumnHeadersHeight = 40;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierName,
            this.email,
            this.DifficultyLevel,
            this.CIN,
            this.InvoiceType,
            this.approvalnumber,
            this.Actions});
            this.dgvSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuppliers.GridColor = System.Drawing.Color.Black;
            this.dgvSuppliers.Location = new System.Drawing.Point(3, 3);
            this.dgvSuppliers.MultiSelect = false;
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSuppliers.RowHeadersVisible = false;
            this.dgvSuppliers.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliers.RowTemplate.DividerHeight = 1;
            this.dgvSuppliers.Size = new System.Drawing.Size(694, 247);
            this.dgvSuppliers.TabIndex = 1;
            // 
            // SupplierName
            // 
            this.SupplierName.HeaderText = "SupplierName";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Supplier Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // DifficultyLevel
            // 
            this.DifficultyLevel.HeaderText = "Difficulty Level";
            this.DifficultyLevel.Name = "DifficultyLevel";
            this.DifficultyLevel.ReadOnly = true;
            // 
            // CIN
            // 
            this.CIN.HeaderText = "CIN";
            this.CIN.Name = "CIN";
            this.CIN.ReadOnly = true;
            // 
            // InvoiceType
            // 
            this.InvoiceType.HeaderText = "InvoiceType";
            this.InvoiceType.Name = "InvoiceType";
            this.InvoiceType.ReadOnly = true;
            // 
            // approvalnumber
            // 
            this.approvalnumber.HeaderText = "Approval #";
            this.approvalnumber.Name = "approvalnumber";
            this.approvalnumber.ReadOnly = true;
            // 
            // Actions
            // 
            this.Actions.HeaderText = "Actions";
            this.Actions.Name = "Actions";
            this.Actions.ReadOnly = true;
            // 
            // tbRoleMapping
            // 
            this.tbRoleMapping.Controls.Add(this.dgvUserRoleMapping);
            this.tbRoleMapping.Controls.Add(this.pnlUserRole);
            this.tbRoleMapping.Location = new System.Drawing.Point(4, 41);
            this.tbRoleMapping.Name = "tbRoleMapping";
            this.tbRoleMapping.Size = new System.Drawing.Size(700, 253);
            this.tbRoleMapping.TabIndex = 2;
            this.tbRoleMapping.Text = "User Role Mappping";
            this.tbRoleMapping.UseVisualStyleBackColor = true;
            this.tbRoleMapping.Enter += new System.EventHandler(this.tbRoleMapping_Enter);
            // 
            // dgvUserRoleMapping
            // 
            this.dgvUserRoleMapping.AllowUserToAddRows = false;
            this.dgvUserRoleMapping.AllowUserToDeleteRows = false;
            this.dgvUserRoleMapping.AllowUserToOrderColumns = true;
            this.dgvUserRoleMapping.AllowUserToResizeColumns = false;
            this.dgvUserRoleMapping.AllowUserToResizeRows = false;
            this.dgvUserRoleMapping.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserRoleMapping.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvUserRoleMapping.ColumnHeadersHeight = 40;
            this.dgvUserRoleMapping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUserRoleMapping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.codevalue,
            this.active});
            this.dgvUserRoleMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserRoleMapping.GridColor = System.Drawing.Color.Black;
            this.dgvUserRoleMapping.Location = new System.Drawing.Point(0, 51);
            this.dgvUserRoleMapping.MultiSelect = false;
            this.dgvUserRoleMapping.Name = "dgvUserRoleMapping";
            this.dgvUserRoleMapping.ReadOnly = true;
            this.dgvUserRoleMapping.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvUserRoleMapping.RowHeadersVisible = false;
            this.dgvUserRoleMapping.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserRoleMapping.RowTemplate.DividerHeight = 1;
            this.dgvUserRoleMapping.Size = new System.Drawing.Size(700, 202);
            this.dgvUserRoleMapping.TabIndex = 3;
            this.dgvUserRoleMapping.Enter += new System.EventHandler(this.dgvUserRoleMapping_Enter);
            // 
            // pnlUserRole
            // 
            this.pnlUserRole.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlUserRole.Controls.Add(this.cbUsers);
            this.pnlUserRole.Controls.Add(this.panel5);
            this.pnlUserRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserRole.Location = new System.Drawing.Point(0, 0);
            this.pnlUserRole.Name = "pnlUserRole";
            this.pnlUserRole.Size = new System.Drawing.Size(700, 51);
            this.pnlUserRole.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.eNewButton1);
            this.panel5.Controls.Add(this.btnUserRoleSave);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(450, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 51);
            this.panel5.TabIndex = 11;
            // 
            // eNewButton1
            // 
            this.eNewButton1.AutoSize = true;
            this.eNewButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.eNewButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eNewButton1.DisplayFocus = true;
            this.eNewButton1.ForeColor = System.Drawing.Color.White;
            this.eNewButton1.Highlight = true;
            this.eNewButton1.Location = new System.Drawing.Point(138, 7);
            this.eNewButton1.Name = "eNewButton1";
            this.eNewButton1.Size = new System.Drawing.Size(100, 35);
            this.eNewButton1.Style = MetroFramework.MetroColorStyle.Purple;
            this.eNewButton1.TabIndex = 11;
            this.eNewButton1.Text = "Cancel";
            this.eNewButton1.UseCustomBackColor = true;
            this.eNewButton1.UseCustomForeColor = true;
            this.eNewButton1.UseSelectable = true;
            this.eNewButton1.UseStyleColors = true;
            // 
            // btnUserRoleSave
            // 
            this.btnUserRoleSave.AutoSize = true;
            this.btnUserRoleSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.btnUserRoleSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserRoleSave.DisplayFocus = true;
            this.btnUserRoleSave.ForeColor = System.Drawing.Color.White;
            this.btnUserRoleSave.Highlight = true;
            this.btnUserRoleSave.Location = new System.Drawing.Point(21, 7);
            this.btnUserRoleSave.Name = "btnUserRoleSave";
            this.btnUserRoleSave.Size = new System.Drawing.Size(100, 35);
            this.btnUserRoleSave.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnUserRoleSave.TabIndex = 10;
            this.btnUserRoleSave.Text = "Save";
            this.btnUserRoleSave.UseCustomBackColor = true;
            this.btnUserRoleSave.UseCustomForeColor = true;
            this.btnUserRoleSave.UseSelectable = true;
            this.btnUserRoleSave.UseStyleColors = true;
            // 
            // cbUsers
            // 
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Location = new System.Drawing.Point(114, 21);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(121, 21);
            this.cbUsers.TabIndex = 12;
            // 
            // Id
            // 
            this.Id.HeaderText = "codevalue";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // codevalue
            // 
            this.codevalue.HeaderText = "Module";
            this.codevalue.Name = "codevalue";
            this.codevalue.ReadOnly = true;
            // 
            // active
            // 
            this.active.HeaderText = "Select";
            this.active.Name = "active";
            this.active.ReadOnly = true;
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 358);
            this.Controls.Add(this.tbAdminModule);
            this.Name = "AdminHome";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.tbAdminModule.ResumeLayout(false);
            this.tbUser.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tbSupplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.tbRoleMapping.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRoleMapping)).EndInit();
            this.pnlUserRole.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tbUser;
        private System.Windows.Forms.TabPage tbSupplier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tbRoleMapping;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn userrole;
        private System.Windows.Forms.DataGridViewTextBoxColumn difficulty;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private eGrid dgvUsers;
        private eGrid dgvSuppliers;
        private eNewButton btnAudit;
        private eNewButton btnAddUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifficultyLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvalnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actions;
        private MetroFramework.Controls.MetroTabControl tbAdminModule;
        private eGrid dgvUserRoleMapping;
        private System.Windows.Forms.Panel pnlUserRole;
        private System.Windows.Forms.Panel panel5;
        private eNewButton eNewButton1;
        private eNewButton btnUserRoleSave;
        private System.Windows.Forms.ComboBox cbUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codevalue;
        private System.Windows.Forms.DataGridViewCheckBoxColumn active;
    }
}