﻿using eBatch.Theme.Purple;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.tbAdminModule = new MetroFramework.Controls.MetroTabControl();
            this.tbUser = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAudit = new eBatch.Theme.Purple.eNewButton();
            this.dgvUsers = new eBatch.Theme.Purple.eGrid();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDefault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlUserRole = new System.Windows.Forms.Panel();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.eNewButton1 = new eBatch.Theme.Purple.eNewButton();
            this.btnUserRoleSave = new eBatch.Theme.Purple.eNewButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
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
            this.tbAdminModule.Margin = new System.Windows.Forms.Padding(0);
            this.tbAdminModule.Name = "tbAdminModule";
            this.tbAdminModule.SelectedIndex = 0;
            this.tbAdminModule.Size = new System.Drawing.Size(708, 298);
            this.tbAdminModule.Style = MetroFramework.MetroColorStyle.Purple;
            this.tbAdminModule.TabIndex = 0;
            this.tbAdminModule.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAdminModule.UseCustomBackColor = true;
            this.tbAdminModule.UseCustomForeColor = true;
            this.tbAdminModule.UseSelectable = true;
            this.tbAdminModule.UseStyleColors = true;
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
            this.panel2.Controls.Add(this.bindingNavigator1);
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
            this.btnAudit.Click += new System.EventHandler(this.btnAudit_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToOrderColumns = true;
            this.dgvUsers.AllowUserToResizeColumns = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.ColumnHeadersHeight = 40;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.Role,
            this.userrole,
            this.difficulty,
            this.status,
            this.Action});
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.GridColor = System.Drawing.Color.Silver;
            this.dgvUsers.Location = new System.Drawing.Point(3, 54);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.dgvUsers.Size = new System.Drawing.Size(694, 196);
            this.dgvUsers.TabIndex = 3;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "User Name";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "userRole.RoleName";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
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
            this.dgvSuppliers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.dgvSuppliers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuppliers.GridColor = System.Drawing.Color.Black;
            this.dgvSuppliers.Location = new System.Drawing.Point(3, 3);
            this.dgvSuppliers.MultiSelect = false;
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSuppliers.RowHeadersVisible = false;
            this.dgvSuppliers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSuppliers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSuppliers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
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
            this.dgvUserRoleMapping.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserRoleMapping.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserRoleMapping.ColumnHeadersHeight = 40;
            this.dgvUserRoleMapping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUserRoleMapping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.isDefault,
            this.ModuleName,
            this.Active});
            this.dgvUserRoleMapping.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserRoleMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserRoleMapping.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvUserRoleMapping.GridColor = System.Drawing.Color.Black;
            this.dgvUserRoleMapping.Location = new System.Drawing.Point(0, 51);
            this.dgvUserRoleMapping.MultiSelect = false;
            this.dgvUserRoleMapping.Name = "dgvUserRoleMapping";
            this.dgvUserRoleMapping.ReadOnly = true;
            this.dgvUserRoleMapping.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvUserRoleMapping.RowHeadersVisible = false;
            this.dgvUserRoleMapping.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserRoleMapping.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUserRoleMapping.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.dgvUserRoleMapping.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserRoleMapping.RowTemplate.DividerHeight = 1;
            this.dgvUserRoleMapping.Size = new System.Drawing.Size(700, 202);
            this.dgvUserRoleMapping.TabIndex = 3;
            this.dgvUserRoleMapping.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserRoleMapping_CellContentClick);
            this.dgvUserRoleMapping.Enter += new System.EventHandler(this.dgvUserRoleMapping_Enter);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // isDefault
            // 
            this.isDefault.DataPropertyName = "IsDefault";
            this.isDefault.HeaderText = "IsDefault";
            this.isDefault.Name = "isDefault";
            this.isDefault.ReadOnly = true;
            this.isDefault.Visible = false;
            // 
            // ModuleName
            // 
            this.ModuleName.DataPropertyName = "ModuleName";
            this.ModuleName.HeaderText = "Module Name";
            this.ModuleName.Name = "ModuleName";
            this.ModuleName.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "IsActive";
            this.Active.FalseValue = "false";
            this.Active.HeaderText = "Select";
            this.Active.IndeterminateValue = "";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.TrueValue = "true";
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
            // cbUsers
            // 
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Location = new System.Drawing.Point(114, 21);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(121, 21);
            this.cbUsers.TabIndex = 12;
            this.cbUsers.SelectedIndexChanged += new System.EventHandler(this.cbUsers_SelectedIndexChanged);
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
            this.btnUserRoleSave.Click += new System.EventHandler(this.btnUserRoleSave_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(694, 25);
            this.bindingNavigator1.TabIndex = 10;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 358);
            this.Controls.Add(this.tbAdminModule);
            this.Location = new System.Drawing.Point(0, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tbUser;
        private System.Windows.Forms.TabPage tbSupplier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tbRoleMapping;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn isDefault;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn userrole;
        private System.Windows.Forms.DataGridViewTextBoxColumn difficulty;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}