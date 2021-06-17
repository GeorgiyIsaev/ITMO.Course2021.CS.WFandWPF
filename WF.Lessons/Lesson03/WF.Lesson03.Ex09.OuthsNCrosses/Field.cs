using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OuthsNCrosses
{
    public partial class Field : Control
    {
        public Field()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = this.CreateGraphics();
            Pen pn = new Pen(Color.Black, 3);
            g.DrawRectangle(pn, 1, 1, this.Width-3, this.Height-3);
        }
        
        public void PlayerClick(int PlayerNo)
        {
            if (Text == "")
            {
                Graphics gr=this.CreateGraphics();
                if (PlayerNo == 1)
                {
                    Pen pn = new Pen(Color.Blue, 3);
                    gr.DrawLine(pn, 5, 5, this.Width - 5, this.Height - 5);
                    gr.DrawLine(pn, this.Width - 5, 5, 5, this.Height - 5);
                }
                else
                {
                    Pen pn = new Pen(Color.Red, 3);
                    gr.DrawEllipse(pn, 5, 5, this.Width - 11, this.Height - 11);
                }
                Text = PlayerNo.ToString();
            }
        }   
    }
}
