using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF.Lab07.Ex04.AsyncAwait
{
    public partial class WinAsynchMethod : Form
    {
        private delegate int AsyncSumm(int a, int b);
    

        public WinAsynchMethod()
        {
            InitializeComponent();
            PrintDlegateFunc = new PrintLabel(PrintFunc);
        }

        private int Summ(int a, int b)
        {
            int count = 10;
            while (count-- >0)
            {
                System.Threading.Thread.Sleep(1000);
                lblResult.Invoke(PrintDlegateFunc, new object[] { "Ожидание! "+ count });
            }   
            return a + b;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                // Преобразование типов данных.
                a = Int32.Parse(txbA.Text);
                b = Int32.Parse(txbB.Text);
            }
            catch (Exception)
            {               
                MessageBox.Show("При выполнении преобразования типов возникла ошибка");
                txbA.Text = txbB.Text = "";
                return;
            }
            AsyncSumm summdelegate = new AsyncSumm(Summ);
            AsyncCallback cb = new AsyncCallback(CallBackMethod);
            summdelegate.BeginInvoke(a, b, cb, summdelegate);
        }
        private void CallBackMethod(IAsyncResult ar)
        {
            string str;
            AsyncSumm summdelegate = (AsyncSumm)ar.AsyncState;          
            str = String.Format("Сумма введенных чисел равна {0}", summdelegate.EndInvoke(ar));
            lblResult.Invoke(PrintDlegateFunc, new object[] { str });
            //MessageBox.Show(str, "Результат операции");
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работа кипит!!!");
        }

        /*Реализация доступа к элементам управления из другого потока*/
        delegate void PrintLabel(string str);
        private PrintLabel PrintDlegateFunc;
        void PrintFunc(string str)
        {
            lblResult.Text = str;
        }

        /*Методы async и await*/
        private async void btnDev_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = Int32.Parse(txbA.Text);
                b = Int32.Parse(txbB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов возникла ошибка");
                txbA.Text = txbB.Text = "";              
            return;
            }
            int res = await Subb(a, b);
            lblResult.Text = res.ToString();
        }
        private async Task<int> Subb(int a, int b)
        {
            return await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(5000);
                return a - b;
            }
            );
        }
    }
}
