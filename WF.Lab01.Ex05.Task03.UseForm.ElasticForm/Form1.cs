using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF.Lab01.Ex05.Task03.UseForm.ElasticForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_AddItem_Click(object sender, EventArgs e)
        {
            if(TextBox_Item.Text != "")
            ListBox_Collection.Items.Insert(0, TextBox_Item.Text);
            TextBox_Item.Text = "";
        }
    }
}
