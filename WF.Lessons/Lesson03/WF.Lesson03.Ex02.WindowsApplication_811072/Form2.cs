using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsApplication_811072
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.TextBox textBox1_2f;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private IContainer components;

		public Form2()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

        public Form2(string d)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            textBox1_2f.Text = d;
        }

		public string PhN
		{
			get { return textBox1_2f.Text;}
			set {textBox1_2f.Text=value; }
		}
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1_2f = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(90, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Передача строки";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1_2f
            // 
            this.textBox1_2f.Location = new System.Drawing.Point(96, 72);
            this.textBox1_2f.Name = "textBox1_2f";
            this.textBox1_2f.Size = new System.Drawing.Size(100, 20);
            this.textBox1_2f.TabIndex = 2;
            this.textBox1_2f.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1_2f.Validated += new System.EventHandler(this.textBox2_Validated);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 208);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ваш возраст";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1_2f);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ваше имя";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
		
	this.textBox1_2f.Text = PhN;
				}

		private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || e.KeyChar == ' ')
 			{
				
                errorProvider1.SetError(textBox1_2f, "Помни, что в имени твоем!");
				e.Handled = true;
			//	MessageBox.Show("Помни, что в имени твоем!");
			}
		}

		private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (textBox2.Text == "")
			{
				e.Cancel = false;
			}
			else
			{
				try
				{
                
					double.Parse(textBox2.Text);
					e.Cancel = false;
				}
				catch
				{
					e.Cancel = true;
                    errorProvider1.SetError(textBox2, "Годы берут своё!");
                //    MessageBox.Show("Возраст следует вводить в числовом формате!");
                   
				}
			}


		}

        private void textBox2_Validated(object sender, EventArgs e)
        { 
            errorProvider1.SetError(textBox2, "");
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
               // или по другому
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))  // сравнение кода вводимого символа с числом 8 дает возможность обрабатывать клавишу BackSpase
            {

                errorProvider1.SetError(textBox2, "Помни, что о времени!");
                e.Handled = true;
           
            }
        }
	}
}
