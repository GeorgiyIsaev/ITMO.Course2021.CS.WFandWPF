using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;

namespace AsyncMethodSolution
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnRun;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.TextBox txbA;
		private System.Windows.Forms.TextBox txbB;
		private System.Windows.Forms.Label lblA;
		private System.Windows.Forms.Label lblB;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        void PrintFunc(string str)
        {
            lblResult.Text = str;
        }
        delegate void PrintLabel(string str);
        private PrintLabel PrintDlegateFunc;
		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            PrintDlegateFunc = new PrintLabel(PrintFunc);
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnRun = new System.Windows.Forms.Button();
			this.lblResult = new System.Windows.Forms.Label();
			this.txbA = new System.Windows.Forms.TextBox();
			this.txbB = new System.Windows.Forms.TextBox();
			this.lblA = new System.Windows.Forms.Label();
			this.lblB = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnRun
			// 
			this.btnRun.Location = new System.Drawing.Point(16, 64);
			this.btnRun.Name = "btnRun";
			this.btnRun.TabIndex = 0;
			this.btnRun.Text = "Сумма";
			this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
			// 
			// lblResult
			// 
			this.lblResult.Location = new System.Drawing.Point(128, 64);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(272, 23);
			this.lblResult.TabIndex = 1;
			// 
			// txbA
			// 
			this.txbA.Location = new System.Drawing.Point(88, 24);
			this.txbA.Name = "txbA";
			this.txbA.TabIndex = 2;
			this.txbA.Text = "";
			// 
			// txbB
			// 
			this.txbB.Location = new System.Drawing.Point(296, 24);
			this.txbB.Name = "txbB";
			this.txbB.TabIndex = 3;
			this.txbB.Text = "";
			// 
			// lblA
			// 
			this.lblA.Location = new System.Drawing.Point(8, 24);
			this.lblA.Name = "lblA";
			this.lblA.Size = new System.Drawing.Size(72, 23);
			this.lblA.TabIndex = 4;
			this.lblA.Text = "Значение А";
			this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblB
			// 
			this.lblB.Location = new System.Drawing.Point(216, 24);
			this.lblB.Name = "lblB";
			this.lblB.Size = new System.Drawing.Size(72, 23);
			this.lblB.TabIndex = 5;
			this.lblB.Text = "Значение В";
			this.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(120, 120);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(280, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Work";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(416, 166);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblB);
			this.Controls.Add(this.lblA);
			this.Controls.Add(this.txbB);
			this.Controls.Add(this.txbA);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.btnRun);
			this.Name = "Form1";
			this.Text = "Асинхронный запуск произвольного метода.";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void btnRun_Click(object sender, System.EventArgs e)
		{
            Thread thread = new Thread(new ThreadStart(ThreadFunction));
            thread.Start();

            
			int a, b;

			try
			{
				// Преобразование типов данных.
				a = Int32.Parse(txbA.Text);
				b = Int32.Parse(txbB.Text);
			}
			catch(Exception)
			{
				MessageBox.Show("При выполнении преобразования типов возникла ошибка");
				txbA.Text = txbB.Text = "";
				return;
			}

            
        
            

//			// Создаем экземпляр summdelegate делегата AsyncSumm и инициализируем  его  методом Summ
//			AsyncSumm summdelegate = new AsyncSumm(Summ);
//			// Создаем экземпляр cb  делегата AsyncCallback для завершения вызова.
//			AsyncCallback cb = new AsyncCallback(CallBackMethod);
//			// Запускаем асинхронно метод, прикрепленный к делегату summdelegate
//			summdelegate.BeginInvoke(a, b, cb, summdelegate);
			
            //lblResult.Text = String.Format("Сумма введенных чисел равна {0}", Summ(a,b));
		
      //  lblResult.Invoke(PrintDlegateFunc, new object[] {Summ(a,b).ToString()});
        


        }
        void ThreadFunction()
        {
            int re = Summ(Int32.Parse(txbA.Text),Int32.Parse(txbB.Text));
            System.Threading.Thread.Sleep(3000);
         //   lblResult.Text = re.ToString(); ;
lblResult.Invoke(PrintDlegateFunc, new object[] {re.ToString()});
        }
		/// <summary>
		/// Суммирование двух чисел.
		/// </summary>
		/// <param name="a">Первое число.</param>
		/// <param name="b">Второе число.</param>
		/// <returns>Сумма двех чисел.</returns>
		private int Summ(int a, int b)
		{
			System.Threading.Thread.Sleep(3000);
			
			return a+b;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Start Work!!!");
		}
		/// <summary>
		/// Делегат, принимающий две переменные типа int и возвращающий одну переменную типа int,
		/// для асинхронного запуска метода (Summ)
		///
		/// </summary>
		//private delegate int AsyncSumm(int a, int b);
		/// <summary>
		/// Метод для завершения асинхронного вызова.
		/// </summary>
		/// <param name="ar"></param>
//		private void CallBackMethod(IAsyncResult ar)
//		{
//			AsyncSumm summdelegate = (AsyncSumm)ar.AsyncState;
//			lblResult.Text = String.Format("Сумма введенных чисел равна {0}", summdelegate.EndInvoke(ar));
//		}
	}
}
