using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF.Lab01.Ex05.Task02.UseForm
{
    public partial class StartForm : Form
    {
        Form1 formbase;
        public StartForm()
        {
            formbase = new Form1();
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void Button_BaseForm_Click(object sender, EventArgs e)
        {
            formbase.Show();
            formbase.Activate();
        }
    }
}
