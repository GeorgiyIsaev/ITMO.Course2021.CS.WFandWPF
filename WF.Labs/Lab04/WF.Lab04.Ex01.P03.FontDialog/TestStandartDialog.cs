using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF.Lab04.Ex03.FontDialog
{
    public partial class TestStandartDialog : Form
    {
        public TestStandartDialog()
        {
            InitializeComponent();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK
            && saveFileDialog1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName,
                RichTextBoxStreamType.PlainText);
            }
        }

        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }
    }
}
