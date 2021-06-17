using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SaveFile
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
               // richTextBox1.ForeColor = colorDialog1.Color;
                
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = folderBrowserDialog1.SelectedPath;
                
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //// Create an OpenFileDialog object.
            //OpenFileDialog openFile1 = new OpenFileDialog();

            //// Initialize the OpenFileDialog to look for text files.
            //openFile1.Filter = "Text Files|*.txt";

            //// Check if the user selected a file from the OpenFileDialog.
            //if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)

            //    // Load the contents of the file into a RichTextBox control.
            //    richTextBox1.LoadFile(openFile1.FileName,
            //    RichTextBoxStreamType.PlainText);


            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"c:\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
          
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                            richTextBox1.LoadFile(openFileDialog1.FileName,
                RichTextBoxStreamType.PlainText);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }






        }
    }
}
