using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibonacciForm
{
    public partial class Form1 : Form
    {
        private int numberToCompute = 0;
        private int highestPercentageReached = 0;

        public Form1()
        {
            InitializeComponent();

            InitializeBackgoundWorker();
        }

        private void InitializeBackgoundWorker()
        {
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
        }

        private void startAsyncButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = String.Empty;
            this.numericUpDown1.Enabled = false;
            this.startAsyncButton.Enabled = false;
            this.cancelAsyncButton.Enabled = true;
            
            numberToCompute = (int)numericUpDown1.Value;
            
            highestPercentageReached = 0;
            
            // Запуск асинхронной операции
            backgroundWorker1.RunWorkerAsync(numberToCompute);
        }

        private void cancelAsyncButton_Click(object sender, EventArgs e)
        {
            // Отмена асинхронной операции
            this.backgroundWorker1.CancelAsync();
            
            cancelAsyncButton.Enabled = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            
            // результат арифметической операции
            e.Result = ComputeFibonacci((int)e.Argument, worker, e);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled) // проверка отмены операции
            {
                resultLabel.Text = "Canceled";
                progressBar1.Value = 0;
            }
            else
            {
                // успешное завершение операции - получение результата
                
                resultLabel.Text = e.Result.ToString();
            }

            this.numericUpDown1.Enabled = true;
            startAsyncButton.Enabled = true;

            cancelAsyncButton.Enabled = false;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }



        // метод выполняется  в другом потоке
        
        long ComputeFibonacci(int n, BackgroundWorker worker, DoWorkEventArgs e)
        {
            if ((n < 0) || (n > 91))
            {
                throw new ArgumentException("value must be >= 0 and <= 91", "n");
            }

            long result = 0;
            if (worker.CancellationPending)
            {
                e.Cancel = true;
            }
            else
            {
                if (n < 2)
                {
                    result = 1;
                }
                else
                {
                    result = ComputeFibonacci(n - 1, worker, e) + ComputeFibonacci(n - 2, worker, e);
                }
                // вычисление для отображения хода выполнения процесса
                int percentComplete = (int)((float)n / (float)numberToCompute * 100);
                if (percentComplete > highestPercentageReached)
                {
                    highestPercentageReached = percentComplete;
                    worker.ReportProgress(percentComplete);
                }
            }
            return result;
        }


    }
}
