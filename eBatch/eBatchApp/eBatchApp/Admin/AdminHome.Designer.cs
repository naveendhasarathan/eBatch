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
            this.tbAdminModule = new System.Windows.Forms.TabControl();
            this.tbUser = new System.Windows.Forms.TabPage();
            this.tbSupplier = new System.Windows.Forms.TabPage();
            this.tbRoleMapping = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            //   this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.dgvUsers = new eGrid();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userrole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.difficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAudit = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbAdminModule.SuspendLayout();
            this.tbUser.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAdminModule
            // 
            this.tbAdminModule.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbAdminModule.Controls.Add(this.tbUser);
            this.tbAdminModule.Controls.Add(this.tbSupplier);
            this.tbAdminModule.Controls.Add(this.tbRoleMapping);
            this.tbAdminModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdminModule.Location = new System.Drawing.Point(0, 0);
            this.tbAdminModule.Name = "tbAdminModule";
            this.tbAdminModule.SelectedIndex = 0;
            this.tbAdminModule.Size = new System.Drawing.Size(708, 358);
            this.tbAdminModule.TabIndex = 0;
            // 
            // tbUser
            // 
            this.tbUser.Controls.Add(this.panel2);
            this.tbUser.Controls.Add(this.dgvUsers);
            this.tbUser.Controls.Add(this.panel1);
            this.tbUser.Location = new System.Drawing.Point(4, 25);
            this.tbUser.Name = "tbUser";
            this.tbUser.Padding = new System.Windows.Forms.Padding(3);
            this.tbUser.Size = new System.Drawing.Size(700, 329);
            this.tbUser.TabIndex = 0;
            this.tbUser.Text = "User List";
            this.tbUser.UseVisualStyleBackColor = true;
            // 
            // tbSupplier
            // 
            this.tbSupplier.Location = new System.Drawing.Point(4, 25);
            this.tbSupplier.Name = "tbSupplier";
            this.tbSupplier.Padding = new System.Windows.Forms.Padding(3);
            this.tbSupplier.Size = new System.Drawing.Size(683, 305);
            this.tbSupplier.TabIndex = 1;
            this.tbSupplier.Text = " Supplier List";
            this.tbSupplier.UseVisualStyleBackColor = true;
            // 
            // tbRoleMapping
            // 
            this.tbRoleMapping.Location = new System.Drawing.Point(4, 25);
            this.tbRoleMapping.Name = "tbRoleMapping";
            this.tbRoleMapping.Size = new System.Drawing.Size(683, 305);
            this.tbRoleMapping.TabIndex = 2;
            this.tbRoleMapping.Text = "User Role Mappping";
            this.tbRoleMapping.UseVisualStyleBackColor = true;
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
            // dgvUsers
            // 
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.userrole,
            this.difficulty,
            this.status,
            this.Action});
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.TabIndex = 1;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "User Name";
            this.username.Name = "username";
            // 
            // userrole
            // 
            this.userrole.HeaderText = "User Role";
            this.userrole.Name = "userrole";
            // 
            // difficulty
            // 
            this.difficulty.DataPropertyName = "difficulty_level";
            this.difficulty.HeaderText = "Difficulty Level";
            this.difficulty.Name = "difficulty";
            // 
            // status
            // 
            this.status.DataPropertyName = "active";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btnAudit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 51);
            this.panel2.TabIndex = 2;
            // 
            // btnAudit
            // 
            this.btnAudit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.btnAudit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAudit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudit.ForeColor = System.Drawing.Color.White;
            this.btnAudit.Location = new System.Drawing.Point(16, 12);
            this.btnAudit.Name = "btnAudit";
            this.btnAudit.Size = new System.Drawing.Size(75, 25);
            this.btnAudit.TabIndex = 9;
            this.btnAudit.Text = "Audit Trail";
            this.btnAudit.UseVisualStyleBackColor = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.btnAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(56, 11);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(91, 25);
            this.btnAddUser.TabIndex = 10;
            this.btnAddUser.Text = "Enable User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
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
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 358);
            this.Controls.Add(this.tbAdminModule);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.tbAdminModule.ResumeLayout(false);
            this.tbUser.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbAdminModule;
        private System.Windows.Forms.TabPage tbUser;
        private System.Windows.Forms.TabPage tbSupplier;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tbRoleMapping;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn userrole;
        private System.Windows.Forms.DataGridViewTextBoxColumn difficulty;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAudit;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Panel panel3;
    }
}