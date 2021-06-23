using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Calculator;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleCalculator
{
	/// <summary>
	/// Summary description for CalcUI.
	/// </summary>
	public class CalcUI : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox VersionInfo;
		private System.Windows.Forms.Button KeyExit;
		private System.Windows.Forms.Button KeyDate;
		private System.Windows.Forms.TextBox OutputDisplay;
		private System.Windows.Forms.Button KeyClear;
		private System.Windows.Forms.Button KeyMinus;
		private System.Windows.Forms.Button KeyPlus;
		private System.Windows.Forms.Button KeyEqual;
		private System.Windows.Forms.Button KeyMultiply;
		private System.Windows.Forms.Button KeyDivide;
		private System.Windows.Forms.Button KeyPoint;
		private System.Windows.Forms.Button KeySign;
		private System.Windows.Forms.Button KeyZero;
		private System.Windows.Forms.Button KeyNine;
		private System.Windows.Forms.Button KeyEight;
		private System.Windows.Forms.Button KeySeven;
		private System.Windows.Forms.Button KeySix;
		private System.Windows.Forms.Button KeyFive;
		private System.Windows.Forms.Button KeyFour;
		private System.Windows.Forms.Button KeyThree;
		private System.Windows.Forms.Button KeyTwo;
		private System.Windows.Forms.Button KeyOne;

		// Output Display Constants.
		private const string oneOut = "1";
		private const string twoOut = "2";
		private const string threeOut = "3";
		private const string fourOut = "4";
		private const string fiveOut = "5";
		private const string sixOut = "6";
		private const string sevenOut = "7";
		private const string eightOut = "8";
		private const string nineOut = "9";
		private const string zeroOut = "0";
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ÏÂÌ˛ToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuItemClear;
        private ToolStripMenuItem ToolStripMenuItemExit;
        private ToolStripMenuItem ‚Ë‰ToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuItemNnormal;
        private ToolStripMenuItem ToolStripMenuItemEngineering;
        private Button KeyFactorial;
        private Button KeySqrt;
        private Button KeyPow;
        private Button KeyReverse;
        private Button KeySqrtY;
        private Button KeyPowY;
        private Button KeySqrtEquation;
        private GroupBox groupBox1;
        private Button Button_Factorial;
        private RichTextBox RichTextBox_OutPutFactorial;
        private TextBox TextBox_InputFactorial;
        private ErrorProvider errorProvider2;
        private IContainer components;

        public CalcUI()
		{
			//
			// Required for Windows Form Designer support
			//

			InitializeComponent();

            //
            // Get version information from the Calculator Module.
            //
            PrintDlegateFunc = new PrintRichTextBox(PrintFunc);
            delegatButtonEnabled = new DelegatButtonEnabled(ButtonEnabled);
            VersionInfo.Text = CalcEngine.GetVersion();
			OutputDisplay.Text = "0";
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcUI));
            this.KeyDate = new System.Windows.Forms.Button();
            this.KeyOne = new System.Windows.Forms.Button();
            this.VersionInfo = new System.Windows.Forms.TextBox();
            this.KeySix = new System.Windows.Forms.Button();
            this.KeyFive = new System.Windows.Forms.Button();
            this.KeyEqual = new System.Windows.Forms.Button();
            this.KeyTwo = new System.Windows.Forms.Button();
            this.KeyZero = new System.Windows.Forms.Button();
            this.KeyThree = new System.Windows.Forms.Button();
            this.KeyPlus = new System.Windows.Forms.Button();
            this.KeyExit = new System.Windows.Forms.Button();
            this.KeySign = new System.Windows.Forms.Button();
            this.KeySeven = new System.Windows.Forms.Button();
            this.KeyPoint = new System.Windows.Forms.Button();
            this.KeyNine = new System.Windows.Forms.Button();
            this.OutputDisplay = new System.Windows.Forms.TextBox();
            this.KeyMinus = new System.Windows.Forms.Button();
            this.KeyEight = new System.Windows.Forms.Button();
            this.KeyMultiply = new System.Windows.Forms.Button();
            this.KeyFour = new System.Windows.Forms.Button();
            this.KeyClear = new System.Windows.Forms.Button();
            this.KeyDivide = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ÏÂÌ˛ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemClear = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.‚Ë‰ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNnormal = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEngineering = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyFactorial = new System.Windows.Forms.Button();
            this.KeySqrt = new System.Windows.Forms.Button();
            this.KeyPow = new System.Windows.Forms.Button();
            this.KeyReverse = new System.Windows.Forms.Button();
            this.KeySqrtY = new System.Windows.Forms.Button();
            this.KeyPowY = new System.Windows.Forms.Button();
            this.KeySqrtEquation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Button_Factorial = new System.Windows.Forms.Button();
            this.RichTextBox_OutPutFactorial = new System.Windows.Forms.RichTextBox();
            this.TextBox_InputFactorial = new System.Windows.Forms.TextBox();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // KeyDate
            // 
            this.KeyDate.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDate.ForeColor = System.Drawing.Color.Blue;
            this.KeyDate.Location = new System.Drawing.Point(292, 145);
            this.KeyDate.Name = "KeyDate";
            this.KeyDate.Size = new System.Drawing.Size(56, 40);
            this.KeyDate.TabIndex = 19;
            this.KeyDate.TabStop = false;
            this.KeyDate.Text = "Date";
            this.KeyDate.Click += new System.EventHandler(this.KeyDate_Click);
            // 
            // KeyOne
            // 
            this.KeyOne.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyOne.ForeColor = System.Drawing.Color.Blue;
            this.KeyOne.Location = new System.Drawing.Point(6, 193);
            this.KeyOne.Name = "KeyOne";
            this.KeyOne.Size = new System.Drawing.Size(40, 40);
            this.KeyOne.TabIndex = 2;
            this.KeyOne.TabStop = false;
            this.KeyOne.Text = "1";
            this.KeyOne.Click += new System.EventHandler(this.KeyOne_Click);
            // 
            // VersionInfo
            // 
            this.VersionInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VersionInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VersionInfo.Cursor = System.Windows.Forms.Cursors.No;
            this.VersionInfo.Font = new System.Drawing.Font("Verdana", 8F);
            this.VersionInfo.Location = new System.Drawing.Point(6, 33);
            this.VersionInfo.Name = "VersionInfo";
            this.VersionInfo.ReadOnly = true;
            this.VersionInfo.Size = new System.Drawing.Size(342, 20);
            this.VersionInfo.TabIndex = 0;
            this.VersionInfo.TabStop = false;
            this.VersionInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KeySix
            // 
            this.KeySix.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySix.ForeColor = System.Drawing.Color.Blue;
            this.KeySix.Location = new System.Drawing.Point(102, 145);
            this.KeySix.Name = "KeySix";
            this.KeySix.Size = new System.Drawing.Size(40, 40);
            this.KeySix.TabIndex = 7;
            this.KeySix.TabStop = false;
            this.KeySix.Text = "6";
            this.KeySix.Click += new System.EventHandler(this.KeySix_Click);
            // 
            // KeyFive
            // 
            this.KeyFive.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFive.ForeColor = System.Drawing.Color.Blue;
            this.KeyFive.Location = new System.Drawing.Point(54, 145);
            this.KeyFive.Name = "KeyFive";
            this.KeyFive.Size = new System.Drawing.Size(40, 40);
            this.KeyFive.TabIndex = 6;
            this.KeyFive.TabStop = false;
            this.KeyFive.Text = "5";
            this.KeyFive.Click += new System.EventHandler(this.KeyFive_Click);
            // 
            // KeyEqual
            // 
            this.KeyEqual.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEqual.ForeColor = System.Drawing.Color.Red;
            this.KeyEqual.Location = new System.Drawing.Point(292, 241);
            this.KeyEqual.Name = "KeyEqual";
            this.KeyEqual.Size = new System.Drawing.Size(56, 40);
            this.KeyEqual.TabIndex = 18;
            this.KeyEqual.TabStop = false;
            this.KeyEqual.Text = "=";
            this.KeyEqual.Click += new System.EventHandler(this.KeyEqual_Click);
            // 
            // KeyTwo
            // 
            this.KeyTwo.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyTwo.ForeColor = System.Drawing.Color.Blue;
            this.KeyTwo.Location = new System.Drawing.Point(54, 193);
            this.KeyTwo.Name = "KeyTwo";
            this.KeyTwo.Size = new System.Drawing.Size(40, 40);
            this.KeyTwo.TabIndex = 3;
            this.KeyTwo.TabStop = false;
            this.KeyTwo.Text = "2";
            this.KeyTwo.Click += new System.EventHandler(this.KeyTwo_Click);
            // 
            // KeyZero
            // 
            this.KeyZero.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyZero.ForeColor = System.Drawing.Color.Blue;
            this.KeyZero.Location = new System.Drawing.Point(6, 241);
            this.KeyZero.Name = "KeyZero";
            this.KeyZero.Size = new System.Drawing.Size(40, 40);
            this.KeyZero.TabIndex = 11;
            this.KeyZero.TabStop = false;
            this.KeyZero.Text = "0";
            this.KeyZero.Click += new System.EventHandler(this.KeyZero_Click);
            // 
            // KeyThree
            // 
            this.KeyThree.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyThree.ForeColor = System.Drawing.Color.Blue;
            this.KeyThree.Location = new System.Drawing.Point(102, 193);
            this.KeyThree.Name = "KeyThree";
            this.KeyThree.Size = new System.Drawing.Size(40, 40);
            this.KeyThree.TabIndex = 4;
            this.KeyThree.TabStop = false;
            this.KeyThree.Text = "3";
            this.KeyThree.Click += new System.EventHandler(this.KeyThree_Click);
            // 
            // KeyPlus
            // 
            this.KeyPlus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPlus.ForeColor = System.Drawing.Color.Red;
            this.KeyPlus.Location = new System.Drawing.Point(150, 241);
            this.KeyPlus.Name = "KeyPlus";
            this.KeyPlus.Size = new System.Drawing.Size(40, 40);
            this.KeyPlus.TabIndex = 12;
            this.KeyPlus.TabStop = false;
            this.KeyPlus.Text = "+";
            this.KeyPlus.Click += new System.EventHandler(this.KeyPlus_Click);
            // 
            // KeyExit
            // 
            this.KeyExit.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyExit.ForeColor = System.Drawing.Color.Red;
            this.KeyExit.Location = new System.Drawing.Point(292, 193);
            this.KeyExit.Name = "KeyExit";
            this.KeyExit.Size = new System.Drawing.Size(56, 40);
            this.KeyExit.TabIndex = 21;
            this.KeyExit.TabStop = false;
            this.KeyExit.Text = "Exit";
            this.KeyExit.Click += new System.EventHandler(this.KeyExit_Click);
            // 
            // KeySign
            // 
            this.KeySign.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.KeySign.ForeColor = System.Drawing.Color.Blue;
            this.KeySign.Location = new System.Drawing.Point(102, 241);
            this.KeySign.Name = "KeySign";
            this.KeySign.Size = new System.Drawing.Size(40, 40);
            this.KeySign.TabIndex = 16;
            this.KeySign.TabStop = false;
            this.KeySign.Text = "+/-";
            this.KeySign.Click += new System.EventHandler(this.KeySign_Click);
            // 
            // KeySeven
            // 
            this.KeySeven.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySeven.ForeColor = System.Drawing.Color.Blue;
            this.KeySeven.Location = new System.Drawing.Point(6, 97);
            this.KeySeven.Name = "KeySeven";
            this.KeySeven.Size = new System.Drawing.Size(40, 40);
            this.KeySeven.TabIndex = 8;
            this.KeySeven.TabStop = false;
            this.KeySeven.Text = "7";
            this.KeySeven.Click += new System.EventHandler(this.KeySeven_Click);
            // 
            // KeyPoint
            // 
            this.KeyPoint.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPoint.ForeColor = System.Drawing.Color.Blue;
            this.KeyPoint.Location = new System.Drawing.Point(54, 241);
            this.KeyPoint.Name = "KeyPoint";
            this.KeyPoint.Size = new System.Drawing.Size(40, 40);
            this.KeyPoint.TabIndex = 17;
            this.KeyPoint.TabStop = false;
            this.KeyPoint.Text = ".";
            this.KeyPoint.Click += new System.EventHandler(this.KeyPoint_Click);
            // 
            // KeyNine
            // 
            this.KeyNine.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyNine.ForeColor = System.Drawing.Color.Blue;
            this.KeyNine.Location = new System.Drawing.Point(102, 97);
            this.KeyNine.Name = "KeyNine";
            this.KeyNine.Size = new System.Drawing.Size(40, 40);
            this.KeyNine.TabIndex = 10;
            this.KeyNine.TabStop = false;
            this.KeyNine.Text = "9";
            this.KeyNine.Click += new System.EventHandler(this.KeyNine_Click);
            // 
            // OutputDisplay
            // 
            this.OutputDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OutputDisplay.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.OutputDisplay.Location = new System.Drawing.Point(6, 65);
            this.OutputDisplay.Name = "OutputDisplay";
            this.OutputDisplay.ReadOnly = true;
            this.OutputDisplay.Size = new System.Drawing.Size(342, 26);
            this.OutputDisplay.TabIndex = 1;
            this.OutputDisplay.TabStop = false;
            this.OutputDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // KeyMinus
            // 
            this.KeyMinus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMinus.ForeColor = System.Drawing.Color.Red;
            this.KeyMinus.Location = new System.Drawing.Point(150, 193);
            this.KeyMinus.Name = "KeyMinus";
            this.KeyMinus.Size = new System.Drawing.Size(40, 40);
            this.KeyMinus.TabIndex = 13;
            this.KeyMinus.TabStop = false;
            this.KeyMinus.Text = "-";
            this.KeyMinus.Click += new System.EventHandler(this.KeyMinus_Click);
            // 
            // KeyEight
            // 
            this.KeyEight.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEight.ForeColor = System.Drawing.Color.Blue;
            this.KeyEight.Location = new System.Drawing.Point(54, 97);
            this.KeyEight.Name = "KeyEight";
            this.KeyEight.Size = new System.Drawing.Size(40, 40);
            this.KeyEight.TabIndex = 9;
            this.KeyEight.TabStop = false;
            this.KeyEight.Text = "8";
            this.KeyEight.Click += new System.EventHandler(this.KeyEight_Click);
            // 
            // KeyMultiply
            // 
            this.KeyMultiply.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMultiply.ForeColor = System.Drawing.Color.Red;
            this.KeyMultiply.Location = new System.Drawing.Point(150, 145);
            this.KeyMultiply.Name = "KeyMultiply";
            this.KeyMultiply.Size = new System.Drawing.Size(40, 40);
            this.KeyMultiply.TabIndex = 14;
            this.KeyMultiply.TabStop = false;
            this.KeyMultiply.Text = "*";
            this.KeyMultiply.Click += new System.EventHandler(this.KeyMultiply_Click);
            // 
            // KeyFour
            // 
            this.KeyFour.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFour.ForeColor = System.Drawing.Color.Blue;
            this.KeyFour.Location = new System.Drawing.Point(6, 145);
            this.KeyFour.Name = "KeyFour";
            this.KeyFour.Size = new System.Drawing.Size(40, 40);
            this.KeyFour.TabIndex = 5;
            this.KeyFour.TabStop = false;
            this.KeyFour.Text = "4";
            this.KeyFour.Click += new System.EventHandler(this.KeyFour_Click);
            // 
            // KeyClear
            // 
            this.KeyClear.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyClear.ForeColor = System.Drawing.Color.Red;
            this.KeyClear.Location = new System.Drawing.Point(292, 97);
            this.KeyClear.Name = "KeyClear";
            this.KeyClear.Size = new System.Drawing.Size(56, 40);
            this.KeyClear.TabIndex = 20;
            this.KeyClear.TabStop = false;
            this.KeyClear.Text = "C";
            this.KeyClear.Click += new System.EventHandler(this.KeyClear_Click);
            // 
            // KeyDivide
            // 
            this.KeyDivide.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDivide.ForeColor = System.Drawing.Color.Red;
            this.KeyDivide.Location = new System.Drawing.Point(150, 97);
            this.KeyDivide.Name = "KeyDivide";
            this.KeyDivide.Size = new System.Drawing.Size(40, 40);
            this.KeyDivide.TabIndex = 15;
            this.KeyDivide.TabStop = false;
            this.KeyDivide.Text = "/";
            this.KeyDivide.Click += new System.EventHandler(this.KeyDivide_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ÏÂÌ˛ToolStripMenuItem,
            this.‚Ë‰ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(354, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ÏÂÌ˛ToolStripMenuItem
            // 
            this.ÏÂÌ˛ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemClear,
            this.ToolStripMenuItemExit});
            this.ÏÂÌ˛ToolStripMenuItem.Name = "ÏÂÌ˛ToolStripMenuItem";
            this.ÏÂÌ˛ToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ÏÂÌ˛ToolStripMenuItem.Text = "ÃÂÌ˛";
            // 
            // ToolStripMenuItemClear
            // 
            this.ToolStripMenuItemClear.Name = "ToolStripMenuItemClear";
            this.ToolStripMenuItemClear.Size = new System.Drawing.Size(126, 22);
            this.ToolStripMenuItemClear.Text = "Œ˜ËÒÚËÚ¸";
            this.ToolStripMenuItemClear.Click += new System.EventHandler(this.ToolStripMenuItemClear_Click);
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(126, 22);
            this.ToolStripMenuItemExit.Text = "¬˚ıÓ‰";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // ‚Ë‰ToolStripMenuItem
            // 
            this.‚Ë‰ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNnormal,
            this.ToolStripMenuItemEngineering});
            this.‚Ë‰ToolStripMenuItem.Name = "‚Ë‰ToolStripMenuItem";
            this.‚Ë‰ToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.‚Ë‰ToolStripMenuItem.Text = "¬Ë‰";
            // 
            // ToolStripMenuItemNnormal
            // 
            this.ToolStripMenuItemNnormal.Name = "ToolStripMenuItemNnormal";
            this.ToolStripMenuItemNnormal.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemNnormal.Text = "Œ·˚˜Ì˚È";
            this.ToolStripMenuItemNnormal.Click += new System.EventHandler(this.ToolStripMenuItemNnormal_Click);
            // 
            // ToolStripMenuItemEngineering
            // 
            this.ToolStripMenuItemEngineering.Name = "ToolStripMenuItemEngineering";
            this.ToolStripMenuItemEngineering.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemEngineering.Text = "»ÌÊËÌÂÌ˚È";
            this.ToolStripMenuItemEngineering.Click += new System.EventHandler(this.ToolStripMenuItemEngineering_Click);
            // 
            // KeyFactorial
            // 
            this.KeyFactorial.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFactorial.ForeColor = System.Drawing.Color.Blue;
            this.KeyFactorial.Image = ((System.Drawing.Image)(resources.GetObject("KeyFactorial.Image")));
            this.KeyFactorial.Location = new System.Drawing.Point(198, 193);
            this.KeyFactorial.Name = "KeyFactorial";
            this.KeyFactorial.Size = new System.Drawing.Size(40, 40);
            this.KeyFactorial.TabIndex = 23;
            this.KeyFactorial.TabStop = false;
            this.KeyFactorial.Click += new System.EventHandler(this.KeyFactorial_Click);
            // 
            // KeySqrt
            // 
            this.KeySqrt.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySqrt.ForeColor = System.Drawing.Color.Blue;
            this.KeySqrt.Image = ((System.Drawing.Image)(resources.GetObject("KeySqrt.Image")));
            this.KeySqrt.Location = new System.Drawing.Point(198, 145);
            this.KeySqrt.Name = "KeySqrt";
            this.KeySqrt.Size = new System.Drawing.Size(40, 40);
            this.KeySqrt.TabIndex = 24;
            this.KeySqrt.TabStop = false;
            this.KeySqrt.Click += new System.EventHandler(this.KeySqrt_Click);
            // 
            // KeyPow
            // 
            this.KeyPow.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPow.ForeColor = System.Drawing.Color.Blue;
            this.KeyPow.Image = ((System.Drawing.Image)(resources.GetObject("KeyPow.Image")));
            this.KeyPow.Location = new System.Drawing.Point(198, 97);
            this.KeyPow.Name = "KeyPow";
            this.KeyPow.Size = new System.Drawing.Size(40, 40);
            this.KeyPow.TabIndex = 25;
            this.KeyPow.TabStop = false;
            this.KeyPow.Click += new System.EventHandler(this.KeyPow_Click);
            // 
            // KeyReverse
            // 
            this.KeyReverse.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyReverse.ForeColor = System.Drawing.Color.Red;
            this.KeyReverse.Image = ((System.Drawing.Image)(resources.GetObject("KeyReverse.Image")));
            this.KeyReverse.Location = new System.Drawing.Point(246, 193);
            this.KeyReverse.Name = "KeyReverse";
            this.KeyReverse.Size = new System.Drawing.Size(40, 40);
            this.KeyReverse.TabIndex = 26;
            this.KeyReverse.TabStop = false;
            this.KeyReverse.Click += new System.EventHandler(this.KeyReverse_Click);
            // 
            // KeySqrtY
            // 
            this.KeySqrtY.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySqrtY.ForeColor = System.Drawing.Color.Red;
            this.KeySqrtY.Image = ((System.Drawing.Image)(resources.GetObject("KeySqrtY.Image")));
            this.KeySqrtY.Location = new System.Drawing.Point(246, 145);
            this.KeySqrtY.Name = "KeySqrtY";
            this.KeySqrtY.Size = new System.Drawing.Size(40, 40);
            this.KeySqrtY.TabIndex = 27;
            this.KeySqrtY.TabStop = false;
            this.KeySqrtY.Click += new System.EventHandler(this.KeySqrtY_Click);
            // 
            // KeyPowY
            // 
            this.KeyPowY.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPowY.ForeColor = System.Drawing.Color.Red;
            this.KeyPowY.Image = ((System.Drawing.Image)(resources.GetObject("KeyPowY.Image")));
            this.KeyPowY.Location = new System.Drawing.Point(246, 97);
            this.KeyPowY.Name = "KeyPowY";
            this.KeyPowY.Size = new System.Drawing.Size(40, 40);
            this.KeyPowY.TabIndex = 28;
            this.KeyPowY.TabStop = false;
            this.KeyPowY.Click += new System.EventHandler(this.KeyPowY_Click);
            // 
            // KeySqrtEquation
            // 
            this.KeySqrtEquation.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySqrtEquation.ForeColor = System.Drawing.Color.Red;
            this.KeySqrtEquation.Image = ((System.Drawing.Image)(resources.GetObject("KeySqrtEquation.Image")));
            this.KeySqrtEquation.Location = new System.Drawing.Point(198, 241);
            this.KeySqrtEquation.Name = "KeySqrtEquation";
            this.KeySqrtEquation.Size = new System.Drawing.Size(88, 40);
            this.KeySqrtEquation.TabIndex = 29;
            this.KeySqrtEquation.TabStop = false;
            this.KeySqrtEquation.Click += new System.EventHandler(this.KeySqrtEquation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Button_Factorial);
            this.groupBox1.Controls.Add(this.RichTextBox_OutPutFactorial);
            this.groupBox1.Controls.Add(this.TextBox_InputFactorial);
            this.groupBox1.Location = new System.Drawing.Point(6, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 109);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "‘‡ÍÚÓË‡Î ˜ËÒÎ‡:";
            // 
            // Button_Factorial
            // 
            this.Button_Factorial.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.Button_Factorial.ForeColor = System.Drawing.Color.Red;
            this.Button_Factorial.Location = new System.Drawing.Point(240, 51);
            this.Button_Factorial.Name = "Button_Factorial";
            this.Button_Factorial.Size = new System.Drawing.Size(96, 52);
            this.Button_Factorial.TabIndex = 31;
            this.Button_Factorial.TabStop = false;
            this.Button_Factorial.Text = "œÓÒ˜ËÚ‡Ú¸ Ù‡ÍÚÓË‡Î";
            this.Button_Factorial.Click += new System.EventHandler(this.Button_Factorial_Click);
            // 
            // RichTextBox_OutPutFactorial
            // 
            this.RichTextBox_OutPutFactorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RichTextBox_OutPutFactorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RichTextBox_OutPutFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichTextBox_OutPutFactorial.Location = new System.Drawing.Point(6, 51);
            this.RichTextBox_OutPutFactorial.Name = "RichTextBox_OutPutFactorial";
            this.RichTextBox_OutPutFactorial.ReadOnly = true;
            this.RichTextBox_OutPutFactorial.Size = new System.Drawing.Size(219, 52);
            this.RichTextBox_OutPutFactorial.TabIndex = 32;
            this.RichTextBox_OutPutFactorial.Text = "";
            // 
            // TextBox_InputFactorial
            // 
            this.TextBox_InputFactorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_InputFactorial.BackColor = System.Drawing.Color.Lime;
            this.TextBox_InputFactorial.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.TextBox_InputFactorial.Location = new System.Drawing.Point(6, 19);
            this.TextBox_InputFactorial.Name = "TextBox_InputFactorial";
            this.TextBox_InputFactorial.Size = new System.Drawing.Size(330, 26);
            this.TextBox_InputFactorial.TabIndex = 31;
            this.TextBox_InputFactorial.TabStop = false;
            this.TextBox_InputFactorial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBox_InputFactorial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_InputFactorial_KeyPress);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // CalcUI
            // 
            this.AcceptButton = this.KeyZero;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(354, 418);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.KeySqrtEquation);
            this.Controls.Add(this.KeyFactorial);
            this.Controls.Add(this.KeySqrt);
            this.Controls.Add(this.KeyPow);
            this.Controls.Add(this.KeyReverse);
            this.Controls.Add(this.KeySqrtY);
            this.Controls.Add(this.KeyPowY);
            this.Controls.Add(this.KeyOne);
            this.Controls.Add(this.KeyTwo);
            this.Controls.Add(this.KeyThree);
            this.Controls.Add(this.KeyFour);
            this.Controls.Add(this.KeyFive);
            this.Controls.Add(this.KeySix);
            this.Controls.Add(this.KeySeven);
            this.Controls.Add(this.KeyEight);
            this.Controls.Add(this.KeyNine);
            this.Controls.Add(this.KeyZero);
            this.Controls.Add(this.KeyPlus);
            this.Controls.Add(this.KeyMinus);
            this.Controls.Add(this.KeyMultiply);
            this.Controls.Add(this.KeyDivide);
            this.Controls.Add(this.KeySign);
            this.Controls.Add(this.KeyPoint);
            this.Controls.Add(this.KeyEqual);
            this.Controls.Add(this.KeyDate);
            this.Controls.Add(this.KeyClear);
            this.Controls.Add(this.KeyExit);
            this.Controls.Add(this.OutputDisplay);
            this.Controls.Add(this.VersionInfo);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CalcUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CalcUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		protected void KeyPlus_Click (object sender, System.EventArgs e)
		{
            OutputDisplay.Text = CalcEngine.CalcOperation (CalcEngine.Operator.eAdd);  
        }

		protected void KeyMinus_Click (object sender, System.EventArgs e)
		{
            OutputDisplay.Text = CalcEngine.CalcOperation (CalcEngine.Operator.eSubtract);
		}

		protected void KeyMultiply_Click (object sender, System.EventArgs e)
		{
            OutputDisplay.Text = CalcEngine.CalcOperation (CalcEngine.Operator.eMultiply);
		}

		protected void KeyDivide_Click (object sender, System.EventArgs e)
		{
            OutputDisplay.Text = CalcEngine.CalcOperation (CalcEngine.Operator.eDivide);
		}

		//
		// Other non-numeric key click methods.
		//

		protected void KeySign_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcSign();
		}

		protected void KeyPoint_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcDecimal();
		}

		protected void KeyDate_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.GetDate();
			CalcEngine.CalcReset();
		}

		protected void KeyClear_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcReset();
			OutputDisplay.Text = "0";
		}

		//
		// Perform the calculation.
		//

		protected void KeyEqual_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcEqual();
			CalcEngine.CalcReset();
		}

		//
		// Numeric key click methods.
		//

		protected void KeyNine_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (nineOut);
		}

		protected void KeyEight_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (eightOut);
		}

		protected void KeySeven_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (sevenOut);
		}

		protected void KeySix_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (sixOut);
		}

		protected void KeyFive_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (fiveOut);
		}

		protected void KeyFour_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (fourOut);
		}

		protected void KeyThree_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (threeOut);
		}

		protected void KeyTwo_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (twoOut);
		}

		protected void KeyOne_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (oneOut);
		}

		protected void KeyZero_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (zeroOut);
		}

		//
		// End the program.
		//

		protected void KeyExit_Click (object sender, System.EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new CalcUI());
		}

       
        
        private void KeyPowY_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcOperation(CalcEngine.Operator.ePowY);          
        }

        private void KeyPow_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcPow();
        }

        private void KeySqrt_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcSqrt();    
        }

        private void KeySqrtY_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcSqrtY(); 
        }

        private void KeyFactorial_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcFactorial();   
        }

        private void KeyReverse_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcReverse();           
        }



        private void CalcUI_Load(object sender, EventArgs e)
        {
            /*¬ÒÔÎ˚‚‡˛˘ËÂ ÔÓ‰ÒÍ‡ÁÍË*/
            ToolTip t1 = new ToolTip();
            t1.SetToolTip(KeyZero, "ÕÓÎ¸"); 
            t1.SetToolTip(KeyOne, "Œ‰ËÌ");
            t1.SetToolTip(KeyTwo, "ƒ‚‡");
            t1.SetToolTip(KeyThree, "“Ë");
            t1.SetToolTip(KeySqrtY, " Û·Ë˜ÂÒÍËÈ ÍÓÂÌ¸");
            t1.SetToolTip(KeySqrt, " ‚‡‰‡ÚÌ˚È ÍÓÂÌ¸"); 
            t1.SetToolTip(KeySqrtEquation, " ‚‡‰‡ÚÌÓÂ Û‡‚ÌÂÌËÂ");
            t1.SetToolTip(KeySix, "ÿÂÒÚ¸");
            t1.SetToolTip(KeySign, "ŒÚËˆ‡ÚÂÎ¸ÌÓÂ ÁÌ‡˜ÂÌËÂ"); 
            t1.SetToolTip(KeySeven, "—ÂÏ¸");
            t1.SetToolTip(KeyReverse, "œÂÂ‚ÂÌÛÚ¸ ‰Ó·¸");
            t1.SetToolTip(KeyPowY, "◊ËÒÎÓ ‚ ÒÚÂÔÂÌË");
            t1.SetToolTip(KeyPow, "¬ÓÁ‚ÂÒÚË ‚ Í‚‡‰‡ÚÌÛ˛ ÒÚÂÔÂÌ¸");
            t1.SetToolTip(KeyPoint, "“Ó˜Í‡");
            t1.SetToolTip(KeyPlus, "—ÎÓÊËÚ¸");
            t1.SetToolTip(KeyNine, "ƒÂ‚ˇÚ¸");
            t1.SetToolTip(KeyMultiply, "”ÏÌÓÊËÚ¸");
            t1.SetToolTip(KeyMinus, "¬˚˜ÂÒÚ¸");
            t1.SetToolTip(KeyFour, "◊ÂÚ˚Ë"); 
            t1.SetToolTip(KeyFive, "œˇÚ¸");
            t1.SetToolTip(KeyFactorial, "‘‡ÍÚÓË‡Î");
            t1.SetToolTip(KeyEight, "¬ÓÒÂÏ¸");
            t1.SetToolTip(KeyExit, "¬˚ıÓ‰");
            t1.SetToolTip(KeyEqual, "–‡‚ÌÓ");
            t1.SetToolTip(KeyDivide, "–‡Á‰ÂÎËÚ¸");
            t1.SetToolTip(KeyDate, "ƒ‡Ú‡");
            t1.SetToolTip(KeyClear, "Œ˜ËÒÚËÚ¸");

            StartForma();
        }

        private void KeySqrtEquation_Click(object sender, EventArgs e)
        {
            SqrtEquation sqrtEquation = new SqrtEquation();
            sqrtEquation.ShowDialog();
        }
      

        private void ToolStripMenuItemClear_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcReset();
            OutputDisplay.Text = "0";
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*»ÁÏÂÌËÌÂÌËÂ ‚Ë‰‡ Í‡Î¸ÍÛÎˇÚÓ‡*/
        private void ToolStripMenuItemNnormal_Click(object sender, EventArgs e)
        {
            StartForma();
        }
        private void StartForma()
        {

            KeyPow.Hide();
            KeyPowY.Hide();
            KeySqrt.Hide();
            KeyFactorial.Hide();
            KeySqrtEquation.Hide();
            KeyReverse.Hide();
            KeySqrtY.Hide();
            KeyPowY.Hide();

            KeyClear.Location = new System.Drawing.Point(198, 97);
            KeyDate.Location = new System.Drawing.Point(198, 145);
            KeyExit.Location = new System.Drawing.Point(198, 193);
            KeyEqual.Location = new System.Drawing.Point(198, 241);
            Size = new Size(280, 328);
        }

        private void ToolStripMenuItemEngineering_Click(object sender, EventArgs e)
        {
            KeyPow.Show(); ;
            KeyPowY.Show();
            KeySqrt.Show();
            KeyFactorial.Show();
            KeySqrtEquation.Show();
            KeyReverse.Show();
            KeySqrtY.Show();
            KeyPowY.Show();

            KeyClear.Location = new System.Drawing.Point(292, 97);
            KeyDate.Location = new System.Drawing.Point(292, 145);
            KeyExit.Location = new System.Drawing.Point(292, 193);
            KeyEqual.Location = new System.Drawing.Point(292, 241);
            Size = new Size(370, 456);  
        }

        private void TextBox_InputFactorial_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!char.IsDigit(e.KeyChar))
             {
                e.Handled = true;
                errorProvider2.SetError(RichTextBox_OutPutFactorial, "ÃÓÊÌÓ ‚‚Ó‰ËÚ¸ ÚÓÎ¸ÍÓ ˆËÙ˚");
             }
            else
            {
                errorProvider2.SetError(RichTextBox_OutPutFactorial, string.Empty);
            }
        }


        /*ƒÂÎÂ„‡Ú˚ ‰Îˇ ‡ÒËÌıÓÌÌÓ„Ó ‚˚ÁÓ‚‡ ‰Îˇ Ë˜·ÓÍÒ‡*/
        private delegate string AsyncSumm(double a);
        delegate void PrintRichTextBox(string str);
        private PrintRichTextBox PrintDlegateFunc;
        void PrintFunc(string str)
        {
            RichTextBox_OutPutFactorial.Text = str;
        }
        private void CallBackMethod(IAsyncResult ar)
        {       
            string str;
            AsyncSumm summdelegate = (AsyncSumm)ar.AsyncState;
            str = summdelegate.EndInvoke(ar);

            RichTextBox_OutPutFactorial.Invoke(PrintDlegateFunc, new object[] { str });           
        }

        /*ƒÂÎÂ„‡Ú˚ ‰Îˇ ‡ÒËÌıÓÌÌÓ„Ó ‚˚ÁÓ‚‡ ‰Îˇ ‚Ë‰ËÏÓÒÚË ÍÌÓÔÓÍ*/
        delegate void DelegatButtonEnabled(bool iftrue);
        void ButtonEnabled(bool iftrue)
        {
            Button_Factorial.Enabled = iftrue;
            TextBox_InputFactorial.Enabled = iftrue;

            if (iftrue)
            {
                TextBox_InputFactorial.BackColor = Color.Lime;           
                TextBox_InputFactorial.Text = "";
            }
            else
                TextBox_InputFactorial.BackColor = Color.LightGray;
        }
        private DelegatButtonEnabled delegatButtonEnabled;


        /*¿ÒËÌıÓÌÌ˚È Ù‡ÈÚÓË‡Î Ë ÍÌÓÔÍ‡*/
        private void Button_Factorial_Click(object sender, EventArgs e)
        {            
            if (TextBox_InputFactorial.Text != "") {
                double value;
                if (Double.TryParse(TextBox_InputFactorial.Text, out value) && value > 0)
                {
                    AsyncSumm summdelegate = new AsyncSumm(FactorialLoad);
                    AsyncCallback cb = new AsyncCallback(CallBackMethod);
                    summdelegate.BeginInvoke(value, cb, summdelegate);
                }
            }
        }   
        private string FactorialLoad(double value)
        {
            //Button_Factorial.Enabled = false;
            //TextBox_InputFactorial.Enabled = false;
            Button_Factorial.Invoke(delegatButtonEnabled, new object[] { false }); ;
            int count = 11;
            while (count-- >= 1)
            {
                System.Threading.Thread.Sleep(1000);
                RichTextBox_OutPutFactorial.Invoke(PrintDlegateFunc, new object[] { $"»‰ÂÚ ‡Ò˜ÂÚ Ù‡ÍÚÓË‡Î‡! ({count}s)" });
               // RichTextBox_OutPutFactorial.Text = $"»‰ÂÚ ‡Ò˜ÂÚ Ù‡ÍÚÓË‡Î‡! ({count}s)";
            }

            //double num = 0;
            double numHold = 1;
            //if (Double.TryParse(TextBox_InputFactorial.Text, out num) && num > 0)
            //{             
                for (int i = 1; i < value + 1; i++)
                {
                    numHold *= i;
                }
            //}

            string temp = CalcEngine.CalcFactorial();

            //RichTextBox_OutPutFactorial.Invoke(delegatButtonEnabled, new object[] { true }); ;
            Button_Factorial.Invoke(delegatButtonEnabled, new object[] { true }); ;
            //  RichTextBox_OutPutFactorial.Text = $"‘‡ÍÚÓË‡Î ˜ËÒÎ‡ {TextBox_InputFactorial.Text} ‡‚ÂÌ:\n{numHold}";
            //TextBox_InputFactorial.Text = "";
            //Button_Factorial.Enabled = true;
            //TextBox_InputFactorial.Enabled = true;

            return $"‘‡ÍÚÓË‡Î ˜ËÒÎ‡ {value} ‡‚ÂÌ:\n{numHold}";
        }       
    }
}
