using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication3
{
    class Class1 : System.Windows.Forms.Control
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            Brush b = new LinearGradientBrush(new Point(1, 1), new Point(60, 60), Color.White, Color.Red);
            Point[] points = new Point[]
{new Point(10, 10), 
    new Point(17, 50), 
    new Point(59, 18),
    new Point(20, 59), 
    new Point(30, 41)}; ;
            g.FillPolygon(b, points);
            }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }
    }
}
