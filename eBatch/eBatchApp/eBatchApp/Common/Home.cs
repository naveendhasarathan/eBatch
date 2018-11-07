using eBatch.Theme.Purple;
using eBatchApp.Admin;
using eBatchApp.DataEntry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace eBatchApp.Common
{
    public partial class Home : eForm
    {
        public Home()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;
           
            RemoveCloseButton();
            researchandRejectToolStripMenuItem.Text = "RESEARCH " + Environment.NewLine + " && REJECT";
            //dataPrepToolStripMenuItem
            dataPrepToolStripMenuItem.Text = "DATA " + Environment.NewLine + "PREP";
            //dataEntryToolStripMenuItem
            dataEntryToolStripMenuItem.Text = "DATA " + Environment.NewLine + "ENTRY";
        }

        private void mnuApplication_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            ToolStripItem clickedItem = e.ClickedItem;
            string itemName = clickedItem.Text;

            switch (itemName)
            {
                case "ADMIN":
                    break;
                case "Users":
                    AdminHome Home = new AdminHome();
                    Home.MdiParent = this;
                    Home.WindowState = FormWindowState.Maximized;
                    Home.Show();
                    break;
                //case "Suppliers":
                //    FrmSupplier frmSupplier = new FrmSupplier();
                //    frmSupplier.MdiParent = this;
                //    frmSupplier.WindowState = FormWindowState.Maximized;
                //    frmSupplier.Show();
                //    break;
                //case "Data Entry":
                //    FrmDataEntry frmDataEntry = new FrmDataEntry();
                //    frmDataEntry.MdiParent = this;
                //    frmDataEntry.WindowState = FormWindowState.Maximized;
                //    frmDataEntry.Show();
                //    break;
                //case "Invoice Details":
                //    FrmDataEntry frmDataEntry = new FrmDataEntry();
                //    frmDataEntry.MdiParent = this;
                //    frmDataEntry.WindowState = FormWindowState.Maximized;
                //    frmDataEntry.Show();
                //    break;
                //case "File List":
                //    FrmFilelist FrmFilelist = new FrmFilelist();
                //    FrmFilelist.MdiParent = this;
                //    FrmFilelist.WindowState = FormWindowState.Maximized;
                //    FrmFilelist.Show();
                //    break;
                case "Exit":
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminHome frmAdmin = new AdminHome();
            frmAdmin.MdiParent = this;
            frmAdmin.WindowState = FormWindowState.Maximized;
            frmAdmin.Show();

            //User u.Show();ser = new User();
            //user.MdiParent = this;
            //user.WindowState = FormWindowState.Maximized;
            //user.Show();
        }

        // dataEntryToolStripMenuItem
        private void dataEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmDataEntry frmDataEntry = new FrmDataEntry();
            //frmDataEntry.MdiParent = this;
            //frmDataEntry.WindowState = FormWindowState.Maximized;
            //frmDataEntry.Show();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //FrmFilelist FrmFilelist = new FrmFilelist();
            //FrmFilelist.MdiParent = this;
            //FrmFilelist.WindowState = FormWindowState.Maximized;
            //FrmFilelist.Show();
        }


        private void FrmBase_MdiChildActivate(object sender, EventArgs e)
        {
            /*

            if (this.ActiveMdiChild == null)
                tabForms.Visible = false;
            // If no any child form, hide tabControl 
            else
            {
                this.ActiveMdiChild.WindowState =
                FormWindowState.Maximized;
                // Child form always maximized 

                // If child form is new and no has tabPage, 
                // create new tabPage 
                if (this.ActiveMdiChild.Tag == null)
                {
                    // Add a tabPage to tabControl with child 
                    // form caption 
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                    tp.Tag = this.ActiveMdiChild;
                    tp.Parent = tabForms;
                    tabForms.SelectedTab = tp;
                    this.ActiveMdiChild.Tag = tp;
                    this.ActiveMdiChild.FormClosed += new FormClosedEventHandler(ActiveMdiChild_FormClosed);
                }

                if (!tabForms.Visible) tabForms.Visible = true;

            }
            */
        }

        private void ActiveMdiChild_FormClosed(object sender,
                                    FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {
            panel2.Visible = true;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.ControlBox = false;
            //this.Text = String.Empty;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmSupplier frmSupplier = new FrmSupplier();
            //frmSupplier.MdiParent = this;
            //// Home.WindowState = FormWindowState.Maximized;
            //frmSupplier.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // NativeMethods.AnimateWindow(this.Handle, 500, AW_ACTIVATE | AW_SLIDE | AW_HOR_NEGATIVE | AW_HIDE);

            // this.panel2.Hide();

           // Transition t = new Transition(new TransitionType_EaseInEaseOut(100));
            //t.add(panel2, "Left", 100);
           // t.add(pictureBox1, "Top", 200);
           // t.run();


            panel2.Visible = !panel2.Visible;
        }

        private void InvoiceEntry_Click(object sender, EventArgs e)
        {
            InvoiceEntry frmInvoiceEntry = new InvoiceEntry();
            frmInvoiceEntry.MdiParent = this;
            frmInvoiceEntry.WindowState = FormWindowState.Maximized;
            frmInvoiceEntry.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
