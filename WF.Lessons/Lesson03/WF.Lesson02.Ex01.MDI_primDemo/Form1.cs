using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int forms;

        private void addChildFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms++;
            Form2 aform = new Form2(); 
            aform.MdiParent = this;
            aform.Text = "Form copy " + forms.ToString();
            aform.Show();
            ContextMenu contextM2 = new ContextMenu();
    //        contextM2.MenuItems.
            aform.ContextMenu = contextM2;



        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
