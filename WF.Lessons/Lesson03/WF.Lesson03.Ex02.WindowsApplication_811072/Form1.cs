using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace WindowsApplication_811072
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1_1f;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.HelpProvider helpProvider1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.HelpProvider helpProvider2;
		private System.Windows.Forms.Button button5;
		private System.ComponentModel.IContainer components;


        Form2 newForm2; // вторая форма

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1_1f = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.button5 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider2 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.helpProvider2.SetHelpKeyword(this.button1, resources.GetString("button1.HelpKeyword"));
            this.helpProvider1.SetHelpKeyword(this.button1, resources.GetString("button1.HelpKeyword1"));
            this.helpProvider2.SetHelpNavigator(this.button1, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("button1.HelpNavigator"))));
            this.helpProvider1.SetHelpNavigator(this.button1, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("button1.HelpNavigator1"))));
            this.helpProvider2.SetHelpString(this.button1, resources.GetString("button1.HelpString"));
            this.helpProvider1.SetHelpString(this.button1, resources.GetString("button1.HelpString1"));
            this.button1.Name = "button1";
            this.helpProvider2.SetShowHelp(this.button1, ((bool)(resources.GetObject("button1.ShowHelp"))));
            this.helpProvider1.SetShowHelp(this.button1, ((bool)(resources.GetObject("button1.ShowHelp1"))));
            this.toolTip1.SetToolTip(this.button1, resources.GetString("button1.ToolTip"));
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.helpProvider2.SetHelpKeyword(this.button2, resources.GetString("button2.HelpKeyword"));
            this.helpProvider1.SetHelpKeyword(this.button2, resources.GetString("button2.HelpKeyword1"));
            this.helpProvider2.SetHelpNavigator(this.button2, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("button2.HelpNavigator"))));
            this.helpProvider1.SetHelpNavigator(this.button2, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("button2.HelpNavigator1"))));
            this.helpProvider2.SetHelpString(this.button2, resources.GetString("button2.HelpString"));
            this.helpProvider1.SetHelpString(this.button2, resources.GetString("button2.HelpString1"));
            this.button2.Name = "button2";
            this.helpProvider2.SetShowHelp(this.button2, ((bool)(resources.GetObject("button2.ShowHelp"))));
            this.helpProvider1.SetShowHelp(this.button2, ((bool)(resources.GetObject("button2.ShowHelp1"))));
            this.toolTip1.SetToolTip(this.button2, resources.GetString("button2.ToolTip"));
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1_1f
            // 
            resources.ApplyResources(this.textBox1_1f, "textBox1_1f");
            this.helpProvider1.SetHelpKeyword(this.textBox1_1f, resources.GetString("textBox1_1f.HelpKeyword"));
            this.helpProvider2.SetHelpKeyword(this.textBox1_1f, resources.GetString("textBox1_1f.HelpKeyword1"));
            this.helpProvider1.SetHelpNavigator(this.textBox1_1f, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("textBox1_1f.HelpNavigator"))));
            this.helpProvider2.SetHelpNavigator(this.textBox1_1f, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("textBox1_1f.HelpNavigator1"))));
            this.helpProvider1.SetHelpString(this.textBox1_1f, resources.GetString("textBox1_1f.HelpString"));
            this.helpProvider2.SetHelpString(this.textBox1_1f, resources.GetString("textBox1_1f.HelpString1"));
            this.textBox1_1f.Name = "textBox1_1f";
            this.helpProvider2.SetShowHelp(this.textBox1_1f, ((bool)(resources.GetObject("textBox1_1f.ShowHelp"))));
            this.helpProvider1.SetShowHelp(this.textBox1_1f, ((bool)(resources.GetObject("textBox1_1f.ShowHelp1"))));
            this.toolTip1.SetToolTip(this.textBox1_1f, resources.GetString("textBox1_1f.ToolTip"));
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.helpProvider2.SetHelpKeyword(this.button3, resources.GetString("button3.HelpKeyword"));
            this.helpProvider1.SetHelpKeyword(this.button3, resources.GetString("button3.HelpKeyword1"));
            this.helpProvider2.SetHelpNavigator(this.button3, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("button3.HelpNavigator"))));
            this.helpProvider1.SetHelpNavigator(this.button3, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("button3.HelpNavigator1"))));
            this.helpProvider2.SetHelpString(this.button3, resources.GetString("button3.HelpString"));
            this.helpProvider1.SetHelpString(this.button3, resources.GetString("button3.HelpString1"));
            this.button3.Name = "button3";
            this.helpProvider2.SetShowHelp(this.button3, ((bool)(resources.GetObject("button3.ShowHelp"))));
            this.helpProvider1.SetShowHelp(this.button3, ((bool)(resources.GetObject("button3.ShowHelp1"))));
            this.toolTip1.SetToolTip(this.button3, resources.GetString("button3.ToolTip"));
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.helpProvider1.SetHelpKeyword(this.textBox2, resources.GetString("textBox2.HelpKeyword"));
            this.helpProvider2.SetHelpKeyword(this.textBox2, resources.GetString("textBox2.HelpKeyword1"));
            this.helpProvider1.SetHelpNavigator(this.textBox2, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("textBox2.HelpNavigator"))));
            this.helpProvider2.SetHelpNavigator(this.textBox2, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("textBox2.HelpNavigator1"))));
            this.helpProvider1.SetHelpString(this.textBox2, resources.GetString("textBox2.HelpString"));
            this.helpProvider2.SetHelpString(this.textBox2, resources.GetString("textBox2.HelpString1"));
            this.textBox2.Name = "textBox2";
            this.helpProvider2.SetShowHelp(this.textBox2, ((bool)(resources.GetObject("textBox2.ShowHelp"))));
            this.helpProvider1.SetShowHelp(this.textBox2, ((bool)(resources.GetObject("textBox2.ShowHelp1"))));
            this.toolTip1.SetToolTip(this.textBox2, resources.GetString("textBox2.ToolTip"));
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.helpProvider2.SetHelpKeyword(this.button4, resources.GetString("button4.HelpKeyword"));
            this.helpProvider1.SetHelpKeyword(this.button4, resources.GetString("button4.HelpKeyword1"));
            this.helpProvider2.SetHelpNavigator(this.button4, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("button4.HelpNavigator"))));
            this.helpProvider1.SetHelpNavigator(this.button4, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("button4.HelpNavigator1"))));
            this.helpProvider2.SetHelpString(this.button4, resources.GetString("button4.HelpString"));
            this.helpProvider1.SetHelpString(this.button4, resources.GetString("button4.HelpString1"));
            this.button4.Name = "button4";
            this.helpProvider2.SetShowHelp(this.button4, ((bool)(resources.GetObject("button4.ShowHelp"))));
            this.helpProvider1.SetShowHelp(this.button4, ((bool)(resources.GetObject("button4.ShowHelp1"))));
            this.toolTip1.SetToolTip(this.button4, resources.GetString("button4.ToolTip"));
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // helpProvider1
            // 
            resources.ApplyResources(this.helpProvider1, "helpProvider1");
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.helpProvider2.SetHelpKeyword(this.button5, resources.GetString("button5.HelpKeyword"));
            this.helpProvider1.SetHelpKeyword(this.button5, resources.GetString("button5.HelpKeyword1"));
            this.helpProvider2.SetHelpNavigator(this.button5, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("button5.HelpNavigator"))));
            this.helpProvider1.SetHelpNavigator(this.button5, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("button5.HelpNavigator1"))));
            this.helpProvider2.SetHelpString(this.button5, resources.GetString("button5.HelpString"));
            this.helpProvider1.SetHelpString(this.button5, resources.GetString("button5.HelpString1"));
            this.button5.Name = "button5";
            this.helpProvider2.SetShowHelp(this.button5, ((bool)(resources.GetObject("button5.ShowHelp"))));
            this.helpProvider1.SetShowHelp(this.button5, ((bool)(resources.GetObject("button5.ShowHelp1"))));
            this.toolTip1.SetToolTip(this.button5, resources.GetString("button5.ToolTip"));
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // helpProvider2
            // 
            resources.ApplyResources(this.helpProvider2, "helpProvider2");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1_1f);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.HelpButton = true;
            this.helpProvider2.SetHelpKeyword(this, resources.GetString("$this.HelpKeyword"));
            this.helpProvider1.SetHelpKeyword(this, resources.GetString("$this.HelpKeyword1"));
            this.helpProvider2.SetHelpNavigator(this, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("$this.HelpNavigator"))));
            this.helpProvider1.SetHelpNavigator(this, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("$this.HelpNavigator1"))));
            this.helpProvider1.SetHelpString(this, resources.GetString("$this.HelpString"));
            this.helpProvider2.SetHelpString(this, resources.GetString("$this.HelpString1"));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.helpProvider2.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.helpProvider1.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp1"))));
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.ResumeLayout(false);
            this.PerformLayout();

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

		private void button1_Click(object sender, System.EventArgs e)
		{
		this.button2.Enabled = true;
		this.textBox1_1f.Enabled = true;
		this.button3.Enabled = true;

		}

		private void button2_Click(object sender, System.EventArgs e)
		{
		this.textBox1_1f.Text = "Введите имя";
		}

		protected void button3_Click(object sender, System.EventArgs e)
		{
            newForm2 = new Form2(textBox1_1f.Text);
			

			newForm2.ShowDialog();
			if (newForm2.DialogResult==DialogResult.OK)
			{
                textBox1_1f.Text =  "Здравствуйте, " + newForm2.PhN;
                //textBox1.Text = textBox1.Text+", " + newForm2.PhN+"!!!!";
			}
            //newForm2.Close();
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			this.button2.Enabled = false;
			this.textBox1_1f.Enabled = false;
			this.button3.Enabled = false;
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
		Help.ShowHelp(this,helpProvider2.HelpNamespace);
		}
	}
}
