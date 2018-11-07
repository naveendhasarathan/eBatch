namespace eBatchApp.Common
{
    partial class Home
    {        /// <summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mnuApplication = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPrepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filelisttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InvoiceEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.verificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.researchandRejectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disbursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.mnuApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 107);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(0, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.metroButton1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(737, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(35, 107);
            this.panel4.TabIndex = 2;
            // 
            // metroButton1
            // 
            this.metroButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroButton1.Location = new System.Drawing.Point(0, 84);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(35, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "X";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 107);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mnuApplication);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(71, 455);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // mnuApplication
            // 
            this.mnuApplication.AutoSize = false;
            this.mnuApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.mnuApplication.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnuApplication.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.dataPrepToolStripMenuItem,
            this.dataEntryToolStripMenuItem,
            this.verificToolStripMenuItem,
            this.researchandRejectToolStripMenuItem,
            this.disbursToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.mnuApplication.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mnuApplication.Location = new System.Drawing.Point(0, 0);
            this.mnuApplication.Name = "mnuApplication";
            this.mnuApplication.Size = new System.Drawing.Size(74, 455);
            this.mnuApplication.TabIndex = 0;
            this.mnuApplication.Text = "File";
            this.mnuApplication.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuApplication_ItemClicked);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.AutoSize = false;
            this.adminToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.suppliersToolStripMenuItem});
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.adminToolStripMenuItem.Image = global::eBatchApp.Properties.Resources.Admin;
            this.adminToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(53, 59);
            this.adminToolStripMenuItem.Text = "ADMIN";
            this.adminToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.adminToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.usersToolStripMenuItem.AutoSize = false;
            this.usersToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.usersToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.suppliersToolStripMenuItem.AutoSize = false;
            this.suppliersToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.suppliersToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            this.suppliersToolStripMenuItem.Click += new System.EventHandler(this.suppliersToolStripMenuItem_Click);
            // 
            // dataPrepToolStripMenuItem
            // 
            this.dataPrepToolStripMenuItem.AutoSize = false;
            this.dataPrepToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.dataPrepToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filelisttoolStripMenuItem});
            this.dataPrepToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPrepToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dataPrepToolStripMenuItem.Image = global::eBatchApp.Properties.Resources.DataPrep;
            this.dataPrepToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dataPrepToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dataPrepToolStripMenuItem.Name = "dataPrepToolStripMenuItem";
            this.dataPrepToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.dataPrepToolStripMenuItem.Size = new System.Drawing.Size(71, 59);
            this.dataPrepToolStripMenuItem.Text = "DATA PREP";
            this.dataPrepToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dataPrepToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // filelisttoolStripMenuItem
            // 
            this.filelisttoolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.filelisttoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.filelisttoolStripMenuItem.Name = "filelisttoolStripMenuItem";
            this.filelisttoolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.filelisttoolStripMenuItem.Text = "File list";
            // 
            // dataEntryToolStripMenuItem
            // 
            this.dataEntryToolStripMenuItem.AutoSize = false;
            this.dataEntryToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.dataEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InvoiceEntry});
            this.dataEntryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataEntryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dataEntryToolStripMenuItem.Image = global::eBatchApp.Properties.Resources.DataEntry;
            this.dataEntryToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dataEntryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dataEntryToolStripMenuItem.Name = "dataEntryToolStripMenuItem";
            this.dataEntryToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.dataEntryToolStripMenuItem.Size = new System.Drawing.Size(79, 70);
            this.dataEntryToolStripMenuItem.Text = "DATA ENTRY";
            this.dataEntryToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dataEntryToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // InvoiceEntry
            // 
            this.InvoiceEntry.Name = "InvoiceEntry";
            this.InvoiceEntry.Size = new System.Drawing.Size(126, 22);
            this.InvoiceEntry.Text = "Invoice Entry";
            this.InvoiceEntry.Click += new System.EventHandler(this.InvoiceEntry_Click);
            // 
            // verificToolStripMenuItem
            // 
            this.verificToolStripMenuItem.AutoSize = false;
            this.verificToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.verificToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verificToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.verificToolStripMenuItem.Image = global::eBatchApp.Properties.Resources.Verification;
            this.verificToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.verificToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.verificToolStripMenuItem.Name = "verificToolStripMenuItem";
            this.verificToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.verificToolStripMenuItem.Size = new System.Drawing.Size(58, 75);
            this.verificToolStripMenuItem.Text = "VERIFIC.";
            this.verificToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.verificToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // researchandRejectToolStripMenuItem
            // 
            this.researchandRejectToolStripMenuItem.AutoSize = false;
            this.researchandRejectToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.researchandRejectToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.researchandRejectToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.researchandRejectToolStripMenuItem.Image = global::eBatchApp.Properties.Resources.ResearchReject;
            this.researchandRejectToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.researchandRejectToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.researchandRejectToolStripMenuItem.Name = "researchandRejectToolStripMenuItem";
            this.researchandRejectToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.researchandRejectToolStripMenuItem.Size = new System.Drawing.Size(67, 75);
            this.researchandRejectToolStripMenuItem.Text = "RESEARCH && REJECT";
            this.researchandRejectToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.researchandRejectToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.researchandRejectToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // disbursToolStripMenuItem
            // 
            this.disbursToolStripMenuItem.AutoSize = false;
            this.disbursToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.disbursToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disbursToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.disbursToolStripMenuItem.Image = global::eBatchApp.Properties.Resources.Disbursemen;
            this.disbursToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.disbursToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.disbursToolStripMenuItem.Name = "disbursToolStripMenuItem";
            this.disbursToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.disbursToolStripMenuItem.Size = new System.Drawing.Size(65, 70);
            this.disbursToolStripMenuItem.Text = "DISBURS.";
            this.disbursToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.disbursToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.AutoSize = false;
            this.reportsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportsToolStripMenuItem.Image = global::eBatchApp.Properties.Resources.Reports;
            this.reportsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(63, 70);
            this.reportsToolStripMenuItem.Text = "REPORTS";
            this.reportsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 592);
            this.ControlBox = true;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBase_Load);
            this.MdiChildActivate += new System.EventHandler(this.FrmBase_MdiChildActivate);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.mnuApplication.ResumeLayout(false);
            this.mnuApplication.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        // System.Windows.Forms.MenuStrip
        private System.Windows.Forms.MenuStrip mnuApplication;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPrepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem researchandRejectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disbursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filelisttoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InvoiceEntry;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Panel panel4;
    }
}