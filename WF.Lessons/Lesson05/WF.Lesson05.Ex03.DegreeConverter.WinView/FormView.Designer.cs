namespace DegreeConverter.WinView
{
	partial class FormView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._celsiusBox = new System.Windows.Forms.TextBox();
			this._farenheitBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this._inputBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this._celsiusButton = new System.Windows.Forms.Button();
			this._farenheitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _celsiusBox
			// 
			this._celsiusBox.Location = new System.Drawing.Point(137, 27);
			this._celsiusBox.Name = "_celsiusBox";
			this._celsiusBox.ReadOnly = true;
			this._celsiusBox.Size = new System.Drawing.Size(73, 20);
			this._celsiusBox.TabIndex = 0;
			// 
			// _farenheitBox
			// 
			this._farenheitBox.Location = new System.Drawing.Point(137, 53);
			this._farenheitBox.Name = "_farenheitBox";
			this._farenheitBox.ReadOnly = true;
			this._farenheitBox.Size = new System.Drawing.Size(73, 20);
			this._farenheitBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Градусы Цельсия:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Градусы Фаренгейта:";
			// 
			// _inputBox
			// 
			this._inputBox.Location = new System.Drawing.Point(365, 27);
			this._inputBox.Name = "_inputBox";
			this._inputBox.Size = new System.Drawing.Size(98, 20);
			this._inputBox.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(267, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Новое значение:";
			// 
			// _celsiusButton
			// 
			this._celsiusButton.Location = new System.Drawing.Point(270, 56);
			this._celsiusButton.Name = "_celsiusButton";
			this._celsiusButton.Size = new System.Drawing.Size(89, 23);
			this._celsiusButton.TabIndex = 6;
			this._celsiusButton.Text = "В Цельсиях";
			this._celsiusButton.UseVisualStyleBackColor = true;
			this._celsiusButton.Click += new System.EventHandler(this._celsiusButton_Click);
			// 
			// _farenheitButton
			// 
			this._farenheitButton.Location = new System.Drawing.Point(363, 56);
			this._farenheitButton.Name = "_farenheitButton";
			this._farenheitButton.Size = new System.Drawing.Size(100, 23);
			this._farenheitButton.TabIndex = 7;
			this._farenheitButton.Text = "В Фаренгейтах";
			this._farenheitButton.UseVisualStyleBackColor = true;
			this._farenheitButton.Click += new System.EventHandler(this._farenheitButton_Click);
			// 
			// FormView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 118);
			this.Controls.Add(this._farenheitButton);
			this.Controls.Add(this._celsiusButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this._inputBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._farenheitBox);
			this.Controls.Add(this._celsiusBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormView";
			this.Text = "Degree Converter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox _celsiusBox;
		private System.Windows.Forms.TextBox _farenheitBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button _celsiusButton;
		private System.Windows.Forms.Button _farenheitButton;
		private System.Windows.Forms.TextBox _inputBox;
	}
}

