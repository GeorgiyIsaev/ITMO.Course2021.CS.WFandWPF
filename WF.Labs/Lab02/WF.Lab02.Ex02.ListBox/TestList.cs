﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WF.Lab02.Ex02.ListBox
{
    public partial class TestList : Form
    {
        public TestList()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (peopleList.Text.Length != 0)
            {
                memberList.Items.Add(peopleList.Text);
            }
            else MessageBox.Show("Выберите элемент из списка или введите новый");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            while (memberList.CheckedIndices.Count > 0)
                memberList.Items.RemoveAt(memberList.CheckedIndices[0]);
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            memberList.Sorted = true;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            peopleList.Items.Clear();
            try
            {
                using (FileStream fStream =
                    new FileStream("..\\..\\XMLFile1.xml",
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.ReadWrite))
                {
                    XmlDocument xmlDoc = new XmlDocument(); xmlDoc.Load(fStream);
                    for (int i = 0; i < xmlDoc.DocumentElement.ChildNodes.Count; i++)
                    {
                        peopleList.Items.Add(xmlDoc.DocumentElement.ChildNodes[i].InnerText);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! Нет доступа к файлу XMLFile1.xml\n" + ex.Message);
            }
        }
    }
}
