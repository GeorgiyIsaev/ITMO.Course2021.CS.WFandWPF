using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MyClass;

namespace WF.Lab02.Ex09.Task01.LevelApEx06
{
    public partial class BiblWorm : Form
    {
        List<Item> its = new List<Item>();
        public BiblWorm()
        {
            InitializeComponent();
        }

        /*ЭТО СВОЙСТВА КНИГ*/
        public string Author // автор
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Title // Название
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string PublishHouse // Издательство
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public int Page // Количество страниц
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int Year // Год издания
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }
        public int InvNumber // Инвентарный номер
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }
        public bool Existence // Наличие
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }
        public bool SortInvNumber // Сортировка по инвентарному номеру
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }
        public bool ReturnTime // Возвращение в срок
        {
            get { return checkBox3.Checked; }
            set { checkBox3.Checked = value; }
        }
        public int PeriodUse // Инвентарный номер
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }

        /*ЭТО СВОЙСТВА ЖУРНАЛОВ*/
        public string AuthorJurnal // автор
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public string TitleJurnal  // Название
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }
        public string PublishHouseJurnal  // Издательство
        {
            get { return textBox6.Text; }
            set { textBox6.Text = value; }
        }
        public int PageJurnal  // Количество страниц
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }
        public int YearJurnal  // Год издания
        {
            get { return (int)numericUpDown5.Value; }
            set { numericUpDown5.Value = value; }
        }
        public int InvNumberJurnal  // Инвентарный номер
        {
            get { return (int)numericUpDown6.Value; }
            set { numericUpDown6.Value = value; }
        }
        public bool ExistenceJurnal  // Наличие
        {
            get { return checkBox4.Checked; }
            set { checkBox4.Checked = value; }
        }      
        public bool ReturnTimeJurnal  // Возвращение в срок
        {
            get { return checkBox5.Checked; }
            set { checkBox5.Checked = value; }
        }
        public int PeriodUseJurnal  // Инвентарный номер
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, PublishHouse,
                Page, Year, InvNumber, Existence);
            if (ReturnTime)
                b.ReturnSrok();
            b.PriceBook(PeriodUse);
            its.Add(b);
            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 0;
            Year = 0;
            Existence = ReturnTime = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
                its.Sort();
            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Jurnal b = new Jurnal(AuthorJurnal, TitleJurnal, PublishHouseJurnal,
               PageJurnal, YearJurnal, InvNumberJurnal, ExistenceJurnal);
            if (ReturnTimeJurnal)
                b.ReturnSrok();
            b.PriceBook(PeriodUseJurnal);
            its.Add(b);
            Author = Title = PublishHouseJurnal = "";
            Page = InvNumberJurnal = PeriodUseJurnal = 0;
            Year = 0;
            Existence = ReturnTimeJurnal = false;
        }
    }
}
