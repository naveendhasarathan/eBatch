using eBatch.Theme.Purple;

namespace eBatchApp.Admin
{
    partial class User
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
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.grbUserList = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRecordCount = new eTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.brnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnAudit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.ddlFieldType = new System.Windows.Forms.ComboBox();
            this.txtFieldValue = new eTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gvDisplay = new System.Windows.Forms.DataGridView();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.grpUserDetails = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnADSearch = new System.Windows.Forms.Button();
            this.cmbDiffLevel = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new eTextBox();
            this.txtName = new eTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlGrid.SuspendLayout();
            this.grbUserList.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDisplay)).BeginInit();
            this.pnlDetails.SuspendLayout();
            this.grpUserDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.grbUserList);
            this.pnlGrid.Location = new System.Drawing.Point(45, 38);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(914, 534);
            this.pnlGrid.TabIndex = 0;
            // 
            // grbUserList
            // 
            this.grbUserList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grbUserList.Controls.Add(this.dataGridView1);
            this.grbUserList.Controls.Add(this.groupBox2);
            this.grbUserList.Controls.Add(this.groupBox1);
            this.grbUserList.Controls.Add(this.gvDisplay);
            this.grbUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbUserList.ForeColor = System.Drawing.Color.White;
            this.grbUserList.Location = new System.Drawing.Point(0, 0);
            this.grbUserList.Name = "grbUserList";
            this.grbUserList.Size = new System.Drawing.Size(914, 534);
            this.grbUserList.TabIndex = 0;
            this.grbUserList.TabStop = false;
            this.grbUserList.Text = "UserList";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRecordCount);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.brnNext);
            this.groupBox2.Controls.Add(this.btnPrevious);
            this.groupBox2.Controls.Add(this.btnLast);
            this.groupBox2.Controls.Add(this.btnFirst);
            this.groupBox2.Controls.Add(this.btnAudit);
            this.groupBox2.Location = new System.Drawing.Point(28, 485);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(868, 44);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // txtRecordCount
            // 
            //this.txtRecordCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecordCount.Location = new System.Drawing.Point(808, 12);
            this.txtRecordCount.Name = "txtRecordCount";
            this.txtRecordCount.Size = new System.Drawing.Size(54, 22);
            this.txtRecordCount.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(724, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "No Of Records";
            // 
            // brnNext
            // 
            this.brnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.brnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnNext.Location = new System.Drawing.Point(645, 11);
            this.brnNext.Name = "brnNext";
            this.brnNext.Size = new System.Drawing.Size(75, 25);
            this.brnNext.TabIndex = 12;
            this.brnNext.Text = "&Next";
            this.brnNext.UseVisualStyleBackColor = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(568, 11);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 25);
            this.btnPrevious.TabIndex = 11;
            this.btnPrevious.Text = "&Prev";
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Location = new System.Drawing.Point(490, 11);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 25);
            this.btnLast.TabIndex = 10;
            this.btnLast.Text = "&Last";
            this.btnLast.UseVisualStyleBackColor = false;
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Location = new System.Drawing.Point(414, 11);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 25);
            this.btnFirst.TabIndex = 9;
            this.btnFirst.Text = "&First";
            this.btnFirst.UseVisualStyleBackColor = false;
            // 
            // btnAudit
            // 
            this.btnAudit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.btnAudit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAudit.Location = new System.Drawing.Point(6, 13);
            this.btnAudit.Name = "btnAudit";
            this.btnAudit.Size = new System.Drawing.Size(75, 25);
            this.btnAudit.TabIndex = 8;
            this.btnAudit.Text = "&Audit Log";
            this.btnAudit.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddUser);
            this.groupBox1.Controls.Add(this.ddlFieldType);
            this.groupBox1.Controls.Add(this.txtFieldValue);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Location = new System.Drawing.Point(783, 15);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 25);
            this.btnAddUser.TabIndex = 11;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // ddlFieldType
            // 
            this.ddlFieldType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlFieldType.FormattingEnabled = true;
            this.ddlFieldType.Location = new System.Drawing.Point(292, 16);
            this.ddlFieldType.Name = "ddlFieldType";
            this.ddlFieldType.Size = new System.Drawing.Size(121, 22);
            this.ddlFieldType.TabIndex = 10;
            // 
            // txtFieldValue
            // 
            //this.txtFieldValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFieldValue.Location = new System.Drawing.Point(537, 16);
            this.txtFieldValue.Name = "txtFieldValue";
            this.txtFieldValue.Size = new System.Drawing.Size(150, 22);
            this.txtFieldValue.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(699, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 25);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(425, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Value";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(180, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Field Type";
            // 
            // gvDisplay
            // 
            this.gvDisplay.BackgroundColor = System.Drawing.Color.White;
            this.gvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDisplay.Location = new System.Drawing.Point(28, 95);
            this.gvDisplay.Name = "gvDisplay";
            this.gvDisplay.Size = new System.Drawing.Size(868, 383);
            this.gvDisplay.TabIndex = 1;
            this.gvDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDisplay_CellContentClick);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.grpUserDetails);
            this.pnlDetails.Location = new System.Drawing.Point(45, 38);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(914, 534);
            this.pnlDetails.TabIndex = 2;
            // 
            // grpUserDetails
            // 
            this.grpUserDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(11)))), ((int)(((byte)(102)))));
            this.grpUserDetails.Controls.Add(this.panel1);
            this.grpUserDetails.Controls.Add(this.btnADSearch);
            this.grpUserDetails.Controls.Add(this.cmbDiffLevel);
            this.grpUserDetails.Controls.Add(this.cmbStatus);
            this.grpUserDetails.Controls.Add(this.label5);
            this.grpUserDetails.Controls.Add(this.label4);
            this.grpUserDetails.Controls.Add(this.label6);
            this.grpUserDetails.Controls.Add(this.label7);
            this.grpUserDetails.Controls.Add(this.textBox4);
            this.grpUserDetails.Controls.Add(this.txtName);
            this.grpUserDetails.ForeColor = System.Drawing.Color.White;
            this.grpUserDetails.Location = new System.Drawing.Point(0, 0);
            this.grpUserDetails.Name = "grpUserDetails";
            this.grpUserDetails.Size = new System.Drawing.Size(914, 534);
            this.grpUserDetails.TabIndex = 2;
            this.grpUserDetails.TabStop = false;
            this.grpUserDetails.Text = "UserDetails";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 504);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 27);
            this.panel1.TabIndex = 23;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(11)))), ((int)(((byte)(102)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(752, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(11)))), ((int)(((byte)(102)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(830, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(11)))), ((int)(((byte)(102)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(674, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnADSearch
            // 
            this.btnADSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.btnADSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADSearch.Location = new System.Drawing.Point(351, 67);
            this.btnADSearch.Name = "btnADSearch";
            this.btnADSearch.Size = new System.Drawing.Size(90, 22);
            this.btnADSearch.TabIndex = 22;
            this.btnADSearch.Text = "Search User";
            this.btnADSearch.UseVisualStyleBackColor = false;
            // 
            // cmbDiffLevel
            // 
            this.cmbDiffLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDiffLevel.FormattingEnabled = true;
            this.cmbDiffLevel.Location = new System.Drawing.Point(150, 103);
            this.cmbDiffLevel.Name = "cmbDiffLevel";
            this.cmbDiffLevel.Size = new System.Drawing.Size(200, 22);
            this.cmbDiffLevel.TabIndex = 21;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(150, 144);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 22);
            this.cmbStatus.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(25, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "User Email";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(25, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Status";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(25, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Difficulty Level";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(25, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "User Name";
            // 
            // textBox4
            // 
            //this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(150, 193);
            this.textBox4.Name = "textBox4";
            this.textBox4.TabIndex = 15;
            // 
            // txtName
            // 
            //this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(150, 67);
            this.txtName.Name = "txtName";
            this.txtName.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(856, 338);
            this.dataGridView1.TabIndex = 4;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::eBatchApp.Properties.Resources.BG_2x;
            this.ClientSize = new System.Drawing.Size(984, 604);
            this.ControlBox = false;
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlDetails);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.User_Load);
            this.pnlGrid.ResumeLayout(false);
            this.grbUserList.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDisplay)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.grpUserDetails.ResumeLayout(false);
            this.grpUserDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.GroupBox grbUserList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ComboBox ddlFieldType;
        private eTextBox txtFieldValue;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvDisplay;
        private System.Windows.Forms.GroupBox groupBox2;
        private eTextBox txtRecordCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button brnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnAudit;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.GroupBox grpUserDetails;
        private System.Windows.Forms.Button btnADSearch;
        private System.Windows.Forms.ComboBox cmbDiffLevel;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private eTextBox textBox4;
        private eTextBox txtName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}