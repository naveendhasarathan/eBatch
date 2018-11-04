using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBatch.Theme.Purple
{
    public partial class eButton : Control
    {
        SolidBrush borderBrush, textBrush;
        Rectangle borderRectangle;
        bool active = false;
        StringFormat stringFormat = new StringFormat();


        public override Cursor Cursor { get; set; } = Cursors.Hand;
        public float BorderThickness { get; set; } = 2;

        public eButton()
        {
            borderBrush = new SolidBrush(System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108))))));
            textBrush = new SolidBrush(System.Drawing.Color.White);
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
           // this.Paint += eButton_paint;
           // InitializeComponent();
           // BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
           // //FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
           // //FlatStyle = System.Windows.Forms.FlatStyle.Popup;
           // Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           // ForeColor = System.Drawing.Color.White;
           // Location = new System.Drawing.Point(56, 11);
           // Size = new System.Drawing.Size(91, 25);
           //// UseVisualStyleBackColor = true;
        }

        private void eButton_paint(object sender, PaintEventArgs e)
        {
            borderRectangle = new Rectangle(0, 0, Width, Height);
            e.Graphics.DrawRectangle(new Pen(borderBrush, BorderThickness), borderRectangle);
            e.Graphics.DrawString(this.Text, this.Font, (active) ? textBrush : borderBrush, borderRectangle, stringFormat);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            borderRectangle = new Rectangle(0, 0, Width, Height);
            e.Graphics.DrawRectangle(new Pen(borderBrush, BorderThickness), borderRectangle);
            e.Graphics.DrawString(this.Text, this.Font, (active) ? textBrush : borderBrush, borderRectangle, stringFormat);

        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            base.BackColor= System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            active = true;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            base.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            active = true;
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            
        }
    }
}
