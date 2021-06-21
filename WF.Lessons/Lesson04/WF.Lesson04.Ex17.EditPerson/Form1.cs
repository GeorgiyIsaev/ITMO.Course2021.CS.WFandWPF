using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace EditPerson
{
    public partial class Form1 : Form
    {
        void PrintFunc(StringBuilder str)
        {
          //  richTextBox1.Text = str;
            richTextBox1.Text = str.ToString();
        }
        delegate void PrintLabel(StringBuilder str);
        private PrintLabel PrintDlegateFunc;
        
    //    public ArrayList pers = new ArrayList();
        List<Person> pers = new List<Person>();

        static ReaderWriterLock rw = new ReaderWriterLock();

        public Form1()
        {
            
            InitializeComponent();
            PrintDlegateFunc = new PrintLabel(PrintFunc);
        }

        private void button1_Click(object sender, EventArgs e)
        {

                Person p = new Person();
                
                EditPersonForm editForm = new EditPersonForm(p);
                if (editForm.ShowDialog() != DialogResult.OK)
                    return;

                pers.Add(p);
            
            personsListView.VirtualListSize = pers.Count;
            personsListView.Invalidate();

            //ListViewItem newItem = personsListView.Items.Add(p.FirstName);
            //newItem.SubItems.Add(p.LastName);
            //newItem.SubItems.Add(p.Age.ToString());
            
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (personsListView.SelectedIndices.Count == 0)
                return;

            Person p = pers[personsListView.SelectedIndices[0]];

        //    ListViewItem item = personsListView.SelectedItems[0];
            EditPersonForm editForm = new EditPersonForm(p);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                personsListView.Invalidate();
                //item.Text = p.FirstName;
                //item.SubItems[1].Text = p.LastName;
                //item.SubItems[2].Text = p.Age.ToString();
            }

            //if (personsListView.SelectedItems.Count == 0)
            //    return;

            //ListViewItem item = personsListView.SelectedItems[0];

            //EditPersonForm editForm = new EditPersonForm();

            //editForm.FirstName = item.Text;
            //editForm.LastName = item.SubItems[1].Text;
            //editForm.Age = Convert.ToInt32(item.SubItems[2].Text);
            
            //if (editForm.ShowDialog() != DialogResult.OK)
            //    return;

            //item.Text = editForm.FirstName;
            //item.SubItems[1].Text = editForm.LastName;
            //item.SubItems[2].Text = editForm.Age.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.backgroundWorker1.RunWorkerAsync();
            
        }

        private void personsListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex < pers.Count)
            {
                e.Item = new ListViewItem(pers[e.ItemIndex].FirstName);
                e.Item.SubItems.Add(pers[e.ItemIndex].LastName);
                e.Item.SubItems.Add(pers[e.ItemIndex].Age.ToString());
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
             StringBuilder sb = new StringBuilder();

            int i = 0;
            foreach (Person item in pers)
            {

                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                }
                else
                {
                    sb.Append("Сотрудник: \n" + item.ToString());
                    richTextBox1.Invoke(PrintDlegateFunc, new object[] { sb });
                    System.Threading.Thread.Sleep(2000);
                    i++;
                    //   richTextBox1.Text = sb.ToString();
                    backgroundWorker1.ReportProgress((100 * i) / pers.Count);
                }
            }

        }

               
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show("Process was cancelled!");
            else
                MessageBox.Show("Background process completed");
        }
    }
    }

