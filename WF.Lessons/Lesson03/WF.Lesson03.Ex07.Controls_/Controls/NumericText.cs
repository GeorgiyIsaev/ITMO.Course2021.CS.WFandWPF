using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace NumericTextBox
{

	[ToolboxBitmap(typeof(NumericTextBox), "Controls.NumericTextBox.ico")]
	public class NumericTextBox : System.Windows.Forms.TextBox
	{
		public delegate void InvalidUserEntryEvent(object sender,KeyPressEventArgs e);
		public event InvalidUserEntryEvent InvalidUserEntry;


		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public NumericTextBox(System.ComponentModel.IContainer container)
		{
			/// <summary>
			/// Required for Windows.Forms Class Composition Designer support
			/// </summary>
			container.Add(this);
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public NumericTextBox()
		{
			/// <summary>
			/// Required for Windows.Forms Class Composition Designer support
			/// </summary>
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
		}
		#endregion
		[Category("Appearance")]public Color newBackColor
		{
			get
			{
				this.BackColor;
			}
			set
			{
				this.BackColor;
			}
		}
		protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
		{
			int asciiInteger = Convert.ToInt32(e.KeyChar);
			if (asciiInteger >= 47 && asciiInteger <= 57)
			{
				//If the value of the ASCII converted char type (e.KeyChar) represents 0-9
				//pass the event to Windows for default processing
				e.Handled = false;
				return;
			}
			//If the value of the ASCII converted char type (e.KeyChar) represents BACKSPACE
			//pass the event to Windows for default processing
			if (asciiInteger == 8)
			{
				e.Handled = false;
				return;
			}
			//If the value of the ASCII converted char type (e.KeyChar) is anything else
			//handle the event here by setting Handled=true which prevents the event from being 
			//passed Windows for default processing
			e.Handled = true;
			if (InvalidUserEntry != null)
				InvalidUserEntry(this, e);
		}
		public override string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
				try
				{
					int.Parse(value);
					base.Text = value;
					return;
				}
				catch
				{}
				if (value == null)
				{
					base.Text = value;
					return;
				}
			}	
		}
	}
}
