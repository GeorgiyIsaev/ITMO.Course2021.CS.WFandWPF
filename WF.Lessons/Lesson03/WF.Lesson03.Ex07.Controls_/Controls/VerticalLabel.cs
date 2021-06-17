using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using System.Drawing;

	[ToolboxBitmap(typeof(VerticalLabel), "Controls.VerticalLabel.ico")]
	public class VerticalLabel : System.Windows.Forms.Control
		//Since we are not using the additional resources/capabilities of 
		//UserControl we will inherit from Control instead to save overhead

		//Inherits System.Windows.Forms.UserControl
	{
		private string labelText;
		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public VerticalLabel(System.ComponentModel.IContainer container)
		{
			/// <summary>
			/// Required for Windows.Forms Class Composition Designer support
			/// </summary>
			container.Add(this);
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//			
			this.Resize += new System.EventHandler(this.VTextBox_Resize);
			
		}

		public VerticalLabel()
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
	
		protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
		{
			float sngControlWidth;
			float sngControlHeight;

			float sngTransformX;
			float sngTransformY;

			Color labelColor = new Color();
			Pen labelBorderPen = new Pen(labelColor, 0);
			SolidBrush labelBackColorBrush = new SolidBrush(labelColor);
			SolidBrush labelForeColorBrush  = new SolidBrush(base.ForeColor);

			if (this.DesignMode)
				base.ResizeRedraw = true;

			base.OnPaint(e);

			sngControlWidth = this.Size.Width;
			sngControlHeight = this.Size.Height;

			e.Graphics.DrawRectangle(labelBorderPen, 0, 0, sngControlWidth, sngControlHeight);
			e.Graphics.FillRectangle(labelBackColorBrush, 0, 0, sngControlWidth, sngControlHeight);

			// set the translation point for the graphics object - the new (0,0) location
			sngTransformX = 0;
			sngTransformY = sngControlHeight;

			// translate the origin used for rotation and drawing 
			e.Graphics.TranslateTransform(sngTransformX, sngTransformY); // (0, textwidth);

			//set the rotation angle for vertical text
			e.Graphics.RotateTransform(270);

			// draw the text on the control
			e.Graphics.DrawString(labelText, Font, labelForeColorBrush, 0, 0);

		}

		private void VTextBox_Resize(object sender , System.EventArgs e) 
		{
			base.Invalidate();
		}


		public override string Text
		{
			get
			{ return labelText;}
			set
			{
				labelText = value;
				Invalidate();
			}
		}

	}

