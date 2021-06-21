using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TestMethodInvoker
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnAddSync;
		private System.Windows.Forms.Button btnAddAsyncMI;
		private System.Windows.Forms.Button btnAsync;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

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
			this.btnAddSync = new System.Windows.Forms.Button();
			this.btnAddAsyncMI = new System.Windows.Forms.Button();
			this.btnAsync = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAddSync
			// 
			this.btnAddSync.Location = new System.Drawing.Point(80, 160);
			this.btnAddSync.Name = "btnAddSync";
			this.btnAddSync.Size = new System.Drawing.Size(128, 23);
			this.btnAddSync.TabIndex = 2;
			this.btnAddSync.Text = "Sync";
			this.btnAddSync.Click += new System.EventHandler(this.btnAddSync_Click);
			// 
			// btnAddAsyncMI
			// 
			this.btnAddAsyncMI.Location = new System.Drawing.Point(80, 208);
			this.btnAddAsyncMI.Name = "btnAddAsyncMI";
			this.btnAddAsyncMI.Size = new System.Drawing.Size(128, 23);
			this.btnAddAsyncMI.TabIndex = 1;
			this.btnAddAsyncMI.Text = "Async with MI";
			this.btnAddAsyncMI.Click += new System.EventHandler(this.btnAddAsyncMI_Click);
			// 
			// btnAsync
			// 
			this.btnAsync.Location = new System.Drawing.Point(80, 184);
			this.btnAsync.Name = "btnAsync";
			this.btnAsync.Size = new System.Drawing.Size(128, 23);
			this.btnAsync.TabIndex = 3;
			this.btnAsync.Text = "Async";
			this.btnAsync.Click += new System.EventHandler(this.btnAsync_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.btnAsync);
			this.Controls.Add(this.btnAddSync);
			this.Controls.Add(this.btnAddAsyncMI);
			this.Name = "Form1";
			this.Text = "TestMethodInvoker";
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
		private void btnAddSync_Click(object sender, System.EventArgs e)
		{
			// Синхронный запуск метода UpdateUI
			UpdateUI();		
		}
		
		// Делегат для вызова метода UpdateUI асинхронно.
		delegate void AddItemAsyncDelegate();

		private void btnAddAsyncMI_Click(object sender, System.EventArgs e)
		{
			// Асинхронный вызов метода UpdateAsync
			AddItemAsyncDelegate asyncDel = new AddItemAsyncDelegate(UpdateAsync);
			asyncDel.BeginInvoke(null, null);
		}
		private void UpdateAsync()
		{
			// Асинхронный вызов метода UpdateUI
			MethodInvoker methodinvoker = new MethodInvoker(UpdateUI);
			this.BeginInvoke(methodinvoker);
		}
		private void UpdateUI()
		{
			// Добавление элемента управления.
			Button btn = new Button();
			btn.Text = "Кнопка";
			this.Controls.Add(btn);
		}
		

		private void btnAsync_Click(object sender, System.EventArgs e)
		{
			// Асинхронный вызов метода UpdateUI
			AddItemAsyncDelegate asyncDel = new AddItemAsyncDelegate(UpdateUI);
			asyncDel.BeginInvoke(null, null);
		}
			
	}
}
